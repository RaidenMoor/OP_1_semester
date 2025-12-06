using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Объявление перменных, которые часто используются в программе
            Container check = new Container(); //Создание контейнера для проверки контейнеров перед загрузкой на склад
            double[] informationOfContainer = new double[5]; //Создание списка для информации о контейнере
            int numberOfBox; //Количество ящиков (для ввода в новый контейнер)
            double weightOfBox; //Вес ящика (для ввода в новый контейнер)
            double costOfBox; //Стоимости за киллограм в ящике (для ввода в новый контейнер)

            Console.WriteLine("Добро пожаловать в интерфейс программы 'Склад овощей'");
            Console.WriteLine("Для начала работы с программой необходимо задать параматры склада");
            Console.WriteLine("Укажите максимальное количество контейнеров. Позже вы не сможете изменить эту величину");
            int maxNumberOfContainers = StaticVoid.InputInt(); //Ввод максимального количества контейнеров на складе
            Console.WriteLine("Укажите стоимость хранения контейнера на складе в рублях. Допустимо введение цифр после запятой.");
            double price = StaticVoid.InputDouble(); //Ввод стоимости хранения контейнера на складе
            Warehouse warehouse = new Warehouse(maxNumberOfContainers, price); //
            while (true) //Цикл основного меню
            {
                Console.WriteLine("\nМеню работы со складом:");
                Console.WriteLine("0. Выход из программы;");
                Console.WriteLine("1.Вывести полную информация о складе;");
                Console.WriteLine("2.Получить информацию о хранимых контейнерах");
                Console.WriteLine("3.Добавить контейнер;");
                Console.WriteLine("4.Работа с контейнером;");
                string menu = Console.ReadLine();
                Console.Clear();

                switch (menu)
                {
                    case "0":
                        return;

                    case "1": //Вывод информации о складе
                        InfornationOfWarehouse(warehouse);
                        break;

                    case "2": //Вывод информации о хранимых контейнерах
                        InformationOfContainers(warehouse);
                        break;

                    case "3": //Добавление контейнера
                        CreateContainer(warehouse);
                        break;

                    case "4":
                        workWithContainer(warehouse);
                        break;

                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод.");
                        break;
                }
            }
        }

        static void InfornationOfWarehouse(Warehouse warehouse)
        {
            Console.WriteLine("Информация о складе:");
            warehouse.ToPrint();
        }

        static void InformationOfContainers(Warehouse warehouse)
        {
            for (int i = 0; i < (warehouse.Information()[1]); i++) //Цикл вывод информации
            {
                Console.WriteLine("Информация о контейнер №" + (i + 1));
                Console.WriteLine(warehouse.conteinerForEdit(i).ToPrint());
                Console.WriteLine("-------------------------------------");
            }
        }

        static void CreateContainer(Warehouse warehouse)
        {
            Container check = new Container();
            Console.WriteLine("Новый контейнер успешно создан");
            double[] informationOfContainer = check.Information(); //Получение информации о вновь созданном контейнере
            Console.WriteLine((check.ToPrintNewContainer()));
            Console.WriteLine("Введите количество ящиков, которые вы хотите добавить в контейнер");
            int numberOfBox = StaticVoid.InputInt(); //Ввод количества ящиков
            double weightOfBox;
            double costOfBox;
            bool flag = true; //Флаг (для возможности остановки ввода до окончания цикла for)
            for (int i = 1; i <= numberOfBox; i++) //Цикл ввода
            {
                if (flag == true)
                {
                    Console.WriteLine("Добавление ящика №" + i);
                    Console.WriteLine("Введите вес ящика");
                    weightOfBox = StaticVoid.InputDouble();
                    Console.WriteLine("Введите стоимость груза в ящике");
                    costOfBox = StaticVoid.InputDouble();
                    if (check.AddBox(weightOfBox, costOfBox) == true) //Проверка на свободное место в контейнере
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ящик успешно добавлен!");
                        Console.ResetColor();
                    }
                    else //Места нет - меню ошибки
                    {
                        informationOfContainer = check.Information(); //
                        Console.WriteLine("Ящик не может быть добавлен из-за ограничений по максимальному весу контейнера");
                        Console.WriteLine("Максимальный вес контейнера: " + informationOfContainer[0]);
                        Console.WriteLine("Вес контейнера на данный момент: " + informationOfContainer[1]);
                        Console.WriteLine("\n Выберите действие: \n1. Добавить ящик с другим весом \n2. прекратить добавление новых ящиков");
                        string errorBox = Console.ReadLine();
                        switch (errorBox) //Меню ошибки
                        {
                            case "1": //Попытка добавить ящик с другим весом
                                Console.WriteLine("Введите вес ящика");
                                weightOfBox = StaticVoid.InputDouble();
                                Console.WriteLine("Введите стоимость груза в ящике");
                                costOfBox = StaticVoid.InputDouble();
                                if (check.AddBox(weightOfBox, costOfBox) == true) //Проверка на вместимость
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Ящик успешно добавлен!");
                                    Console.ResetColor();
                                }
                                else //Ошибка - досрочное завершение цикла
                                {
                                    informationOfContainer = check.Information();
                                    Console.WriteLine("Ящик не может быть добавлен из-за ограничений по максимальному весу контейнера");
                                    Console.WriteLine("Максимальный вес контейнера: " + informationOfContainer[0]);
                                    Console.WriteLine("Вес контейнера на данный момент: " + informationOfContainer[1]);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Вы снова ввели недопустимое значение. Добавление ящиков остановлено.");
                                    Console.ResetColor();
                                    flag = false;
                                }
                                break;
                            case "2": //Досрочное завершение ввода
                                Console.WriteLine("Добавление ящиков остановлено");
                                flag = false;
                                break;
                        }
                    }
                }
            }
            if (warehouse.AddCContainer(check) == true) //проверка на рентабельность
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Контейнер успешно добавлен на склад");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Контейнер не добавлен на склад в связи с отвутствием рентабильности");
                Console.ResetColor();
                Console.WriteLine("Стоимость хранения контейнера на складе: " + warehouse.price);
                informationOfContainer = check.Information();
                Console.WriteLine("Стоимость содержимого контейнера: " + informationOfContainer[4]);
            }
        }

        static void workWithContainer(Warehouse warehouse)
        {
            Console.WriteLine("Введите номер контейнера");
            int numberContainerForEdit = StaticVoid.InputInt();
            if (numberContainerForEdit <= warehouse.Information()[3] && numberContainerForEdit > 0) //Проверка существования контейнера
            {
                Container containerForEdit = warehouse.conteinerForEdit(numberContainerForEdit - 1); //Получение экзампляра
                bool flagForContainer = true;//Флаг для меню контейнера
                while (flagForContainer)
                {
                    //Вывод информации о контейнере
                    Console.WriteLine("Информация о контейнере №{0}", numberContainerForEdit);
                    Console.WriteLine(containerForEdit.ToPrint());
                    Console.WriteLine("\nВыберите действие:");
                    Console.WriteLine("1. Удалить контейнер");
                    Console.WriteLine("2. Получить информацию о ящиках");
                    Console.WriteLine("0. Выход");
                    string containerMenu = Console.ReadLine();
                    switch (containerMenu)
                    {
                        case "1": //Удаление контейнера
                            if (warehouse.DeleteContainer(numberContainerForEdit) == true) //Удаление контейнера
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Контейнер успешно удален!");
                                Console.ResetColor();
                            }
                            return;
                        case "2": //Вывод информации о хранимых ящиках
                            Console.WriteLine();
                            Box box;
                            for (int i = 0; i < containerForEdit.Information()[2]; i++)
                            {
                                box = containerForEdit.InformationOfBoxForEdit(i); //Получение экземпляра
                                double[] informationOfBox = box.Information(); //Получение информации о ящике
                                Console.WriteLine("Ящик №{0}", i + 1);
                                Console.WriteLine(box.ToPrint());
                                Console.WriteLine("--------------------");
                            }
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Такого пункта меню нет. Повторите ввод.");
                            break;
                    }
                }
            }
            else Console.WriteLine("Контейнера с таким номером не существует");
        }
    }
}

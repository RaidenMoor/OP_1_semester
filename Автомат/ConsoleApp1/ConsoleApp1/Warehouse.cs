using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Warehouse
    {
        public int maxNumberOfContainers; //Максимальное число контейнеров на складе
        public double price; //Стоимость хранения контейнера на складе
        public List<Container> containers = new List<Container>(); //Список контейнеров

        //Конструктор
        public Warehouse(int maxNumberOfContainers, double price)
        {
            this.maxNumberOfContainers = maxNumberOfContainers; //Задаём максимальное количество контейнеров на складе
            this.price = price; //Задаём стоимость хранения контейнера
        }

        //Функция добавления нового контейнера
        public bool AddCContainer(Container check)
        {
            double[] informationOfContainer = check.Information(); //Получение информация из экземпляра проверки
            List<Box> boxes = check.InformationOfBoxes(); //Получение списка ящиков из экземпляра проверки
            if (informationOfContainer[4] >= price) //проверка рентабельности
            {
                if (containers.Count == maxNumberOfContainers) //Проверка заполненности склада
                {
                    containers.RemoveAt(0); //Если склад заполнен, кдаляем самый старый контейнер
                }
                containers.Add(new Container(informationOfContainer, boxes)); //Добавления контейнера в список
                return true;
            }
            else return false;
        }

        //Функция удаления контейнера
        public bool DeleteContainer(int number)
        {
            if (number <= containers.Count && number > 0) //Есть ли контейнер с таким номером?
            {
                containers.RemoveAt(number - 1); //Удаление контейнера
                return true;
            }
            else return false;
        }

        public Container conteinerForEdit(int number)
        {
            return containers[number]; //Возврат листа с данными о всех контейнерах
        }

        public double[] Information()
        {
            double[] information = new double[3];
            information[0] = maxNumberOfContainers;
            information[1] = containers.Count;
            information[2] = price;
            return information;
        }

        public string ToPrint()
        {
            return ("Всего мест: " + maxNumberOfContainers + "Мест занято: " + containers.Count + "Мест свободно: " + (maxNumberOfContainers - containers.Count));
        }

    }
}

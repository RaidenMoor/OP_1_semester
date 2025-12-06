using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Container
    {
        double maxWeight; //Максимальный вес контейнера
        List<Box> boxes = new List<Box>(); //Информация о ящиках в контейнерах
        double degreeOfDamage; //Степень повреждения

        //Создание пустого конструктора (используется ТОЛЬКО в экземпляре check)
        public Container()
        {
            Random random = new Random(); //Вызов рандома
            maxWeight = random.Next(10, 100); //Генерация максимального веса
            boxes.Clear(); //Очистка списка ящиков
            degreeOfDamage = (random.Next(0, 499)); //Генерация повреждения
            degreeOfDamage /= 1000;
        }

        //Конструктор создания нового контейнера (check==true)
        public Container(double[] informationOfContainer, List<Box> boxes)
        {
            this.maxWeight = informationOfContainer[0]; //Ввод максимального веса
            this.boxes.AddRange(boxes); //Ввод списка ящиков
            this.degreeOfDamage = informationOfContainer[3]; //Ввод степени повреждения
        }

        //Метод для добавления нового ящика в контейнер
        public bool AddBox(double weightOfBox, double costOfKilogram)
        {
            double actualWeight = 0;
            for (int i = 0; i < boxes.Count; i++)
            {
                actualWeight += boxes[i].Information()[0];
            }
            if (actualWeight + weightOfBox <= maxWeight) //Проверка, есть ли место в контейнере (по весу)
            {
                boxes.Add(new Box(weightOfBox, costOfKilogram)); //Добавляем экземпляр в список ящиков
                return true;
            }
            else return false;
        }

        //Удаление ящика из контейнера
        public bool DeleteBox(int numberOfContainer)
        {
            if (numberOfContainer <= boxes.Count()) //Существует ли ящик с таким индексом?
            {
                boxes.RemoveAt(numberOfContainer); //Удалить ящик
                return true;
            }
            else return false;
        }

        //Функция ввода актулаьной информации о контейнере в массив и передача массива
        public double[] Information()
        {
            double[] information = new double[3];
            information[0] = maxWeight;
            information[1] = boxes.Count;
            information[2] = degreeOfDamage;
            return information;
        }

        //Возврат экземпляра ящика
        public Box InformationOfBoxForEdit(int number)
        {
            return boxes[number];
        }

        //Возврат списока ящиков
        public List<Box> InformationOfBoxes()
        {
            return boxes;
        }

        public string ToPrint()
        {
            string maxWeightToPrint = Convert.ToString(maxWeight);
            double actualWeight = 0;
            double money = 0;
            for (int i = 0; i < boxes.Count; i++)
            {
                actualWeight += boxes[i].Information()[0];
                money += (boxes[i].Information()[0] * boxes[i].Information()[1]);
            }
            string actualWeightToPrint = Convert.ToString(actualWeight);
            string degreeOfDamageToPrint = Convert.ToString(degreeOfDamage);
            string moneyToPrint = Convert.ToString(money);
            return ("Максимальный вес: " + maxWeightToPrint + "\nАктуальный вес: " + actualWeightToPrint + "\nСтепень повреждения: " + degreeOfDamageToPrint + "\nСтоимость: " + moneyToPrint);
        }

        public string ToPrintNewContainer()
        {
            return ("Вместимость контейнера: " + maxWeight + "кг." + "\nСтепень повреждения: " + degreeOfDamage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Box
    {
        readonly double weightOfBox; //Вес ящика
        private double costOfKilogram; //Стоимость килограмма груза

        //Конструктор создания ящика
        public Box(double weightOfBox, double costOfKilogram)
        {
            this.weightOfBox = weightOfBox;
            this.costOfKilogram = costOfKilogram;
        }


        //Возврат информации
        public double[] Information()
        {
            double[] information = new double[2];
            information[0] = weightOfBox;
            information[1] = costOfKilogram;
            return information;
        }

        public string ToPrint()
        {
            string weightOfBoxToPrint = Convert.ToString(weightOfBox);
            string costOfKilogramToPrint = Convert.ToString(costOfKilogram);
            return ("Вес ящика:" + weightOfBoxToPrint + "\nСтоимость килограмм содержимого ящика: " + costOfKilogramToPrint);
        }

    }
}

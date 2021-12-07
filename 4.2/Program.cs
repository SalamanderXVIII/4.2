using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.2, высокий уровень, 2-й вариант, Гребенюк.
            string[,] Crossovermaloletky = { {"Джанго Фетт",""},{"Хорус Луперкаль",""},{"Семён Персунов",""}, {"Престон Гарви",""}, {"Красный Принц",""}, {"Чайный пакетик",""}, {"Джо Байден",""}, {"[ДАННЫЕ УДАЛЕНЫ]",""}, {"Сон Гоку",""}, {"Моя крыша",""}, {"Выходные",""}, {"Габриэль Ангелос",""}, { "Panzerkampfwagen IV", ""}, {"Ясь",""}, {"Кошка-жена",""}, {"Furry, LGBT, black trans-woman",""} };
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                Crossovermaloletky[i, 1] = Convert.ToString(Convert.ToDouble(rnd.Next(100, 125) / 10.0));
            }
            for (int i = 0; i < 16; i++)
            {
                Console.Write(Crossovermaloletky[i, 0] + " - ");
                Console.WriteLine(Crossovermaloletky[i, 1] + " сек.");
            }
            double[] mas = new double[16];
            for (int i = 0; i < 16; i++)
            {
                mas[i] = Convert.ToDouble(Crossovermaloletky[i, 1]);
            }
            Array.Sort(mas);
            Console.WriteLine("");
            Console.WriteLine("Лучшие бегуны: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (Crossovermaloletky[j, 1] == Convert.ToString(mas[i]))
                    {
                        Console.Write(Crossovermaloletky[j, 0] + " - ");
                        Console.WriteLine(Crossovermaloletky[j, 1] + " сек.");
                        Crossovermaloletky[j, 1] = "13";
                        break;
                    }

                }
            }
        }
    }
}

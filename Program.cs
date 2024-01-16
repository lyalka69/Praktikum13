using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Пракикум 13 - Сакары Анны";

            //1.Обработать тестовое задание по информатике. На экран вывести вопрос и три варианта ответа, ввести с экрана
            //вариант ответа. Программа должна оценить ответ и в случае неправильного ответа написать правильный.

            //Console.Write("\n1.Какая самая маленькая единица измерения информации? \nВарианты ответа: \n1)Килобайт \n2)Байт \n3)Бит \nВведите номер верного варианта ответа: ");
            //int s = int.Parse(Console.ReadLine());
            //int c = 3;
            //string v, h;
            //v = "Вы ответили верно, поздравляю!";
            //h = "Неверно, верный вариант ответа: ";
            //if (s == 3)
            //    Console.WriteLine(v);
            //else
            //    Console.WriteLine(h +" "+ c);

            //Console.ReadKey();


            //2.Написать программу вычисления стоимости переговоров, если по субботам и воскресеньям предоставляется 20% скидка.
            //Ввести продолжительность разговора и день недели(цифра от 1 до 7).

            //int minute = 15; //одна минута стоит 15 копеек
            //Console.Write("\nВведите продолжительность разговора в минутах: ");
            //int min = int.Parse(Console.ReadLine());
            //Console.Write("Введите день недели(цифру от 1 до 7): ");
            //int z = int.Parse(Console.ReadLine());
            //int b = min * minute;

            //if (z == 1 | z == 2 | z == 3 | z == 4 | z == 5)
            //{
            //    Console.WriteLine(b);
            //}
            //else if (z == 6 | z == 7)
            //{
            //    Console.WriteLine(b - ((b * 20) / 100));
            //}
            //Console.ReadKey();

            //3. Написать программу для определения времени суток по данному текущему времени и вывести сообщение
            //(утро – с 6 до 12, день – с 12 до 18, вечер – с 18 до 24, ночь – с 0 до 6).

            //Console.Write("Введите текущее время (Н-р: 13:25): ");
            //double hour = double.Parse(Console.ReadLine());
            //switch (hour) 
            //{
            //    case 0: case 1: case 2: case 3: case 4: case 5:
            //        Console.WriteLine("Ночь"); break;
            //    case 6: case 7: case 8: case 9: case 10: case 11:
            //        Console.WriteLine("Утро"); break;
            //    case 12: case 13: case 14: case 15: case 16: case 17:
            //        Console.WriteLine("День"); break;
            //    case 18: case 19: case 20: case 21: case 22: case 23:
            //        Console.WriteLine("Вечер"); break;
            //}

            //Console.ReadKey();


            //4. Рейтинг бакалавра заочного отделения при поступлении в магистратуру определяется средним баллом по диплому,
            //умноженным на коэффициент стажа работы по специальности,
            //который равен: нет стажа – 1, меньше 2 лет – 13, от 2 до 5 лет – 16.
            //Составить программу расчета рейтинга при заданном среднем балле диплома
            //(от 3 до 5) и вывести сообщение о приеме в магистратуру при проходном балле 45.

            //Console.Write("Введите ваш средний балл: ");
            //double gpa = double.Parse(Console.ReadLine());
            //Console.Write("Укажите ваш стаж работы: ");
            //double experience = double.Parse(Console.ReadLine());

            //double point = 1, point1 = gpa * 1, point2 = gpa * 13, point3 = gpa * 16;

            //if (experience == 0)
            //{
            //    Console.WriteLine($"Ваш рейтинг: {point1}");
            //}
            //if (experience > 0 & experience < 2)
            //{
            //    Console.WriteLine($"Ваш рейтинг: {point2}");
            //}
            //if (experience >= 2 & experience <= 5)
            //{
            //    Console.WriteLine($"Ваш рейтинг: {point3}");
            //}
            //if (point >= 45 | gpa >= 3)
            //{
            //    Console.WriteLine("Вы приняты в магистратуру");
            //}
            //else if (gpa < 3 | point <= 45)
            //{
            //    Console.WriteLine("Вы не приняты в магистратуру");
            //}

            //Console.ReadKey();


            //5.Написать программу , которая по дате рождения(день d месяц n) определяет знак Зодиака:
            //с 22 марта по 21 апреля - Овен(4); с 22 апреля по 21 мая - Телец(5); с 22 мая по 21 июня - Близнецы(6);
            //с 22 июня по 21 июля - Рак(7); с 22 июля по 21 августа - Лев(8); с 22 августа по 21 сентября - Дева(9);
            //22 сентября по 21 октября - Весы(10); с 22 октября по 21 ноября - Скорпион(11); с 22 ноября по 21 декабря - Стрелец(12);
            //с 22 декабря по 21 января - Козерог(1); 22 января по 21 февраля - Водолей(2); с 22 февраля по 21 марта - Рыбы(3).

            //Console.Write("Укажите вашу дату рождения :) \nмесяц: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("день: ");
            //int d = int.Parse(Console.ReadLine());

            //Console.Write($"Ваш знак зодиака: ");

            //if ((n == 1 && d >= 21) || (n == 2 && d <= 19))
            //{
            //    Console.WriteLine("водолей");
            //}
            //else if ((n == 2 && d >= 20) || (n == 3 && d <= 20))
            //{
            //    Console.WriteLine("рыбы");
            //}
            //else if ((n == 3 && d >= 21) || (n == 4 && d <= 20))
            //{
            //    Console.WriteLine("овен");
            //}
            //else if ((n == 4 && d >= 21) || (n == 5 && d <= 21))
            //{
            //    Console.WriteLine("телец");
            //}
            //else if ((n == 5 && d >= 22) || (n == 6 && d <= 21))
            //{
            //    Console.WriteLine("близнецы");
            //}
            //else if ((n == 6 && d >= 22) || (n == 7 && d <= 22))
            //{
            //    Console.WriteLine("рак");
            //}
            //else if ((n == 7 && d >= 23) || (n == 8 && d <= 23))
            //{
            //    Console.WriteLine("лев");
            //}
            //else if ((n == 8 && d >= 24) || (n == 9 && d <= 23))
            //{
            //    Console.WriteLine("дева");
            //}
            //else if ((n == 9 && d >= 24) || (n == 10 && d <= 23))
            //{
            //    Console.WriteLine("весы");
            //}
            //else if ((n == 10 && d >= 24) || (n == 11 && d <= 22))
            //{
            //    Console.WriteLine("скорпион");
            //}
            //else if ((n == 11 && d >= 23) || (n == 12 && d <= 22))
            //{
            //    Console.WriteLine("стрелец");
            //}
            //else if ((n == 12 && d >= 23) || (n == 1 && d <= 20))
            //{
            //    Console.WriteLine("козерог");
            //}

            //Console.ReadKey();

            //6. Написать программу,
            //которая при вводе числа в диапазоне от 1 до 99 добавляет к нему слово "копейка"
            //в правильной форме. Например, 1 копейка, 5 копеек, 42 копейки.

            //Console.Write("введите число от 1 до 99: ");
            //int kopeck = int.Parse(Console.ReadLine());

            //if (kopeck % 10 >= 5 | kopeck % 10 <= 0 | kopeck >= 5 & kopeck <= 20)
            //{
            //    Console.Write($"{kopeck} копеек");
            //}
            //else if (kopeck % 10 == 1)
            //{
            //    Console.Write($"{kopeck} копейка ");
            //}
            //else if (kopeck % 10 >= 2 | kopeck % 10 <= 4)
            //{
            //    Console.Write($"{kopeck} копейки");
            //}

            //Console.ReadKey();

            //7. Написать программу, которая после введенного с клавиатуры числа в диапазоне от 1 до 99 дописывает слово «рубль» в правильном падеже.


            //Console.Write("введите число от 1 до 99: ");
            //int money = int.Parse(Console.ReadLine());

            //if (money % 10 >= 5 | money % 10 <= 0 | money >= 5 & money <= 20)
            //{
            //    Console.Write($"{money} рублей");
            //}
            //else if (money % 10 == 1)
            //{
            //    Console.Write($"{money} рубль ");
            //}
            //else if (money % 10 >= 2 | money % 10 <= 4)
            //{
            //    Console.Write($"{money} рубля");
            //}

            //Console.ReadKey();

        }
    }
}

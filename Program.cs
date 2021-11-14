using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // *Написать игру, в которою могут играть два игрока.
            // *При старте, игрокам предлагается ввести свои никнеймы.
            // *Никнеймы хранятся до конца игры.
            // *Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!

            /*
            #region Задание 1. Приложение по определению чётного или нечётного числа

            Console.WriteLine("The program for determining an even or uneven number.");
            Console.WriteLine("Enter number: ");
            int numberEven = Convert.ToInt32(Console.ReadLine());

            if (numberEven % 2 == 0)
            {
                Console.WriteLine($"Number { numberEven } - even number!");
            }
            else
            {
                Console.WriteLine($"Number { numberEven } - uneven number!");
            }

            #endregion
            */

            /*
            #region Задание 2. Программа подсчёта суммы карт в игре «21»
            
            Console.WriteLine("The program \"Blackjack\"");
            int sum = 0;

            Console.WriteLine("Enter the number of cards: ");
            int countCard = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= countCard; i++)
            {
                Console.WriteLine("Enter card: ");
                string numberCard = Console.ReadLine();
                switch (numberCard)
                {
                    case "J":
                        sum += 10;
                        break;
                    case "Q":
                        sum += 10;
                        break;
                    case "K":
                        sum += 10;
                        break;
                    case "T":
                        sum += 11;
                        break;
                    default:
                        int count = Convert.ToInt32(numberCard);
                        sum += count;
                        break;
                }
            }

            Console.WriteLine($"Sum cards = { sum }");
            Console.ReadKey();
            #endregion
            */


            #region Задание 3. Проверка простого числа

            Console.WriteLine("Enter number: ");
            int numberPrime = Convert.ToInt32(Console.ReadLine());
            bool result = true;
            int count = 2;

            while (count < numberPrime)
            {
                if(numberPrime % count == 0)
                {
                    result = false;
                    break;
                }

                count++;
            }

            if (result)
            {
                Console.WriteLine($"{ numberPrime } - is prime number!");
            }
            else
            {
                Console.WriteLine($"{ numberPrime } - is not a prime number!");
            }

            Console.ReadKey();
            #endregion


            
            #region Реализация тестового задания

            //Указание колличества игроков
            //Если указан один игрок то игра с компьютером
            int countPlayers;
            string[] players;
            Console.WriteLine("Enter count players: ");
            countPlayers = Convert.ToInt32(Console.ReadLine());
            bool playerII = (countPlayers == 1);


            //Создание массива игроков
            if (playerII)
            {
                players = new string[countPlayers + 1];
                players[1] = "Computer";
            }
            else
            {
                players = new string[countPlayers];
            }
            

            //Инициализация игроков
            for (int i = 0; i < countPlayers; i++)
            {
                Console.WriteLine($"Enter name player { i + 1 }: ");
                players[i] = Console.ReadLine();
            }

            //Задать диапазон чисел
            int[] gameNumbers = new int[2];
            Console.WriteLine("Enter min number: ");
            gameNumbers[0] = Convert.ToInt32(Console.ReadLine()) + 1;

            Console.WriteLine("Enter max number: ");
            gameNumbers[1] = Convert.ToInt32(Console.ReadLine());


            Random rand = new Random();
            int gameNumber = rand.Next(gameNumbers[0], gameNumbers[1]);

            int number;

            //Логика игры
            do
            {
                Console.Clear();
                for (int i = 0; i < players.Length; i++)
                {
                    
                    Console.WriteLine($"Число: { gameNumber }");

                    //Прверка "игра с компьютером" или "многопользовательская игра"
                    if (playerII && i == 1)
                    {
                        number = rand.Next(1, 5);
                        Console.WriteLine($"Player { players[i] } entered number: { number }");
                    }
                    else
                    {
                        Console.WriteLine($"Player { players[i] } enter number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                    }

                    //Проверка вводимого диапазона числа
                    if(number < 1 || number > 4)
                    {
                        Console.Clear();
                        Console.WriteLine("The number must be from 1 to 4!");
                        i--;
                        Console.ReadKey();
                        break;
                    }

                    gameNumber -= number;

                    //Определение победителя
                    if (gameNumber <= 0)
                    {
                        Console.WriteLine($"Player { players[i] } win!!!");
                        break;
                    }

                    Console.ReadKey();
                    Console.Clear();
                }   
            }
            while (gameNumber > 0);

            Console.ReadKey();

            #endregion
            
        }
    }
}

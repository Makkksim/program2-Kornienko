using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
               
                //task1
                double a = 0.7;  // Значення параметра a

                Console.WriteLine("Введіть значення x:");
                double x = Convert.ToDouble(Console.ReadLine());

                double y;
                
                if (x > 0)
                {
                  y = Math.Sqrt(Math.Pow(x, 3) / (x + a)) - Math.Log(x);
                }
                else if (x < 0)
                {
                  y = 2 * a * Math.Log(-x);
                }
                else
                {
                  y = 0;
                }
                  Console.WriteLine($"Значення y: {y}");
                  
                     //Task 2
                    // Запитуємо чотиризначне число у користувача
                    Console.WriteLine("Введіть чотиризначне число:");
                    string input = Console.ReadLine();

                    // Перевіряємо, чи є введене число чотиризначним
                    if (int.TryParse(input, out int number) | input.Length == 4)
                    {
                        int sum = 0;

                        // Обчислюємо суму цифр числа
                        foreach (char digit in input)
                        {
                            sum += digit - '0';  // Перетворення символу цифри в ціле число
                        }

                        // Виводимо результат
                        Console.WriteLine($"Сума цифр числа {number} дорівнює: {sum}");
                    }
                    else
                    {
                        // Виводимо повідомлення про помилку
                        Console.WriteLine("Помилка: введене число не є чотиризначним.");
                         
                    }
                }
                {
                    //tusk 3
                    Console.WriteLine("tusk 3");
                    Console.WriteLine("Введіть сторону a:");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введіть сторону b:");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введіть сторону c:");
                    double c = Convert.ToDouble(Console.ReadLine());

                    if (a + b > c || a + c > b || b + c > a)
                    {
                        Console.WriteLine("Введіть число p (1 - периметр, 2 - площа, 3 - тип трикутника):");
                        int p = Convert.ToInt32(Console.ReadLine());

                        switch (p)
                        {
                            case 1:
                                double perimeter = a + b + c;
                                Console.WriteLine("Периметр трикутника: " + perimeter);
                                break;

                            case 2:
                                double s = (a + b + c) / 2;
                                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                                Console.WriteLine("Площа трикутника: " + area);
                                break;

                            case 3:
                                if (a == b || b == c)
                                {
                                    Console.WriteLine("Трикутник рівносторонній.");
                                }
                                else if (a == b || b == c || a == c)
                                {
                                    Console.WriteLine("Трикутник рівнобедрений.");
                                }
                                else
                                {
                                    Console.WriteLine("Трикутник довільний.");
                                }
                                break;

                            default:
                                Console.WriteLine("Невірне значення p. Введіть 1, 2 або 3.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Сторони не утворюють трикутник.");
                    }
                    Console.ReadKey();
                }
            }


        }
    }



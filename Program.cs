//Юрий Бойцун 
/*1. Написать программу «Анкета». 
 * Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
 * В результате вся информация выводится в одну строчку:
 в) используя вывод со знаком $.*/
using System;

namespace Home_Work_1
{
    class Program
    { 
        static void Main(string[] args)
        {
             void question()
            {
                    Console.Write("Ваше имя:");
                    string name = Console.ReadLine();
                    Console.Clear();

                    Console.Write("Ваша фамилия:");
                    string sname = Console.ReadLine();
                    Console.Clear();

                    Console.Write("Ваш возраст:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Console.Write("Ваш рост в метрах:");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();

                    Console.Write("Ваш вес в килограммах:");
                    int fat = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine
                        ($"Ваше имя:{name}.\n Ваша фамилия:{sname}\n Ваш возраст:{age} полных лет.\n Ваш рост:{height}  метров.\n Ваш вес:{fat} килограмм.");
                    Console.WriteLine("Чтобы продолжить нажмите любую кнопку");
                    Console.ReadKey();
                IMP(name, height, fat);
                
            }

            /*2. Ввести вес и рост человека.
             * Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
             * где m — масса тела в килограммах, h — рост в метрах.*/

              void IMP(string name, double height, int fat)
              {
                  double I = fat / (Math.Pow(height, 2));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{name} индекс массы вашего тела составляет {I:F2}");
                  Console.ReadKey();
              }


              question();
            /*3.
  а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
  б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Введите x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Distance(x1, x2, y1, y2);

            void Distance(int x1, int x2, int y1, int y2)
            {
                
                double dist = 0;
                dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Результат вычисления: {dist:F2}");
                Console.ReadLine();
            }
            
        }
    }
}

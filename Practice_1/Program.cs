/* Задачі на арифметичні та логічні оператори 

Задача 1 Напишіть програму, яка обчислює оплату праці працівника,
враховуючи години роботи та ставку за годину. Використовуйте арифметичні
операції для обчислення оплати. */
/*using System;

namespace SalaryCalculator
{
    
    public class EmployeeSalaryCalculator
    { 
        public double CalculateSalary(double hoursWorked, double hourlyRate)
        {
            double totalPayment = hoursWorked * hourlyRate;

            return totalPayment;
        }
    }

    public class Program
    {
        public static void Main()
        {
            
            Console.Write("Enter the number of hours worked: ");
            double hours = Convert.ToDouble(Console.ReadLine());

           
            Console.Write("Enter the hourly rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());

           
            var salaryCalculator = new EmployeeSalaryCalculator();

            
            double totalSalary = salaryCalculator.CalculateSalary(hours, rate);

          
            Console.WriteLine($"Total salary for the employee: {totalSalary}");
        }
    }
}
*/
/* Задача 2 
Напишіть програму, яка перевіряє, чи є введене користувачем число
простим.Використовуйте арифметичні операції для перевірки дільників числа.
*/
/*
using System;

namespace NumberChecker
{
  
    public class NumberCheckerProgram
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number to check if it is a simple number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsSimpleNumber(number))
            {
                Console.WriteLine($"{number} is a simple number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a simple number.");
            }
        }
        public static bool IsSimpleNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}*/

/* Задача 3 Напишіть програму, яка перевіряє, чи належить введена користувачем
точка колу з відомим центром і радіусом. Використовуйте арифметичні
операції для обчислення відстані від точки до центру кола. */
/*
using System;

namespace CircleUtils
{
    
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public class Circle
    {
        public Point Center { get; private set; }
        public double Radius { get; private set; }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public double CalculateDistanceToPoint(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - Center.X, 2) + Math.Pow(point.Y - Center.Y, 2));
            return distance;
        }
    }


    public class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter the x-coordinate of the center of the circle:");
            double centerX = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the y-coordinate of the center of the circle:");
            double centerY = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            // Не працює, якщо ввести неіснуючй радіус. Зроблю сюди вивід команди, якщо не забуду
            
            Circle circle = new Circle(new Point(centerX, centerY), radius);

           
            Console.WriteLine("Enter the x-coordinate of the point:");
            double pointX = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the y-coordinate of the point:");
            double pointY = Convert.ToDouble(Console.ReadLine());

            Point point = new Point(pointX, pointY);

            
            double distance = circle.CalculateDistanceToPoint(point);

            
            if (Math.Abs(distance - circle.Radius) < 0.0001)
            {
                Console.WriteLine("The point is on the circle.");
            }
            else
            {
                Console.WriteLine("The point is not on the circle.");
            }
        }
    }
}\*
/* Задачі на одновимірні та двовимірні масиви
Задача 1 - Напишіть програму, яка знаходить: суму всіх елементів у заданому
масиві.
- Напишіть програму, яка знаходить мінімальний і максимальний
елементи у масиві.
- Напишіть програму, яка знаходить середнє значення елементів у
масиві.
- Напишіть програму, яка перевіряє, чи міститься певний елемент у
масиві.
*/
using System;
using System.Linq;

namespace ArrayOperations
{
    public class ArrayUtils
    {
     
        public static int[] GenerateRandomArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(1, 101); 
            }

            return array;
        }

        public static int CalculateSum(int[] array)
        {
            return array.Sum();
        }

        public static int FindMinimum(int[] array)
        {
            return array.Min();
        }

        public static int FindMaximum(int[] array)
        {
            return array.Max();
        }

        public static double CalculateAverage(int[] array)
        {
            return array.Average();
        }

        public static bool ContainsElement(int[] array, int numberToCheck)
        {
            return array.Contains(numberToCheck);
        }
    }


    public class Program
    {
        public static void Main()
        {
    
            int[] array = ArrayUtils.GenerateRandomArray(10);
                       
            Console.WriteLine("Generated Array:");
            Console.WriteLine(string.Join(", ", array));
            int sum = ArrayUtils.CalculateSum(array);
            int min = ArrayUtils.FindMinimum(array);
            int max = ArrayUtils.FindMaximum(array);
            double avg = ArrayUtils.CalculateAverage(array);

            Console.Write("Enter a number to check in the array: ");
            int numberToCheck = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum of array elements: {sum}");
            Console.WriteLine($"Minimum element: {min}");
            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Average of elements: {avg}");
                     
            bool containsNumber = ArrayUtils.ContainsElement(array, numberToCheck);
                                 
            Console.WriteLine($"Array {(containsNumber ? "contains" : "does not contain")} the number {numberToCheck}.");
        }
    }
}
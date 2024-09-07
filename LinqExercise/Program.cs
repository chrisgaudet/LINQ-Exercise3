using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sum = numbers.Sum();

            //TODO: Print the Average of numbers
            var average = numbers.Average();

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");


            //TODO: Order numbers in ascending order and print to the console
            var asc = numbers.OrderBy(asc => asc);
            Console.WriteLine("------------------");
            Console.WriteLine("Asc");

            foreach (var num in asc)
            {
                Console.WriteLine(num);
            }

            //TODO: Order numbers in descending order and print to the console
            var desc = numbers.OrderByDescending(desc => desc);
            Console.WriteLine("------------------");
            Console.WriteLine("Desc");

            foreach (var num in desc)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("------------");

            //TODO: Print to the console only the numbers greater than 6
            var aboveSix = numbers.Where(num => num > 6);

            Console.WriteLine("Above Six");

            foreach (var num in aboveSix)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------------");

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("First 4 Ascending");
            foreach (var num in asc.Take(4))
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------------");

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("Changed Index 4 To My Age");
            numbers[4] = 34;

            foreach (var num in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("--------------");
            Console.WriteLine("--------------");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var filtered = employees.Where(x => x.FirstName[0] == ('C') || x.FirstName[0] == ('S')).OrderBy(x => x.FirstName);
            Console.WriteLine("C or S Employees");
            foreach (var employee in filtered)
            {
                Console.WriteLine(employee.FullName);
            }

            Console.WriteLine("-------------");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Full Names Over Age 26");
            
            var overTwentySix = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var employee in overTwentySix)
            {
                Console.WriteLine($"FullName: {employee.FullName} Age: {employee.Age}");
            }

            Console.WriteLine("------------");

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("YOE & Age > 35");

            var years = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            
            var sumOfYOE = years.Sum(emp => emp.YearsOfExperience);
            var avgOfYOE = years.Average(emp => emp.YearsOfExperience);

            Console.WriteLine($"Sum {sumOfYOE} Avg {avgOfYOE}");

            Console.WriteLine("------------");


            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("first", "lastName", 98, 1)).ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.Age}");
            }


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}

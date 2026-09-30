////Entering total amount of workers
//Console.WriteLine("--- Task 1 - Average salary ---");
//Console.Write("Enter number of staff members: ");
//
//int count = int.Parse(Console.ReadLine());
//
//double sum = 0;
//int i = 1;
//
////Entering a salsry for each worker up to total amount of them
//while (i <= count)
//{
//    Console.WriteLine($"Salary of {i} worker: ");
//   double salary = double.Parse(Console.ReadLine());
//
//    sum = sum + salary;
//    i = i + 1;
//}
////Outing average salary of all workers
//double average = sum / count;
//Console.WriteLine($"Average salary: {average}");
///////////////////////////////////////////////////////

//Console.WriteLine("--- Task 2 - Star diagram ---");
//Console.Write("Enter number of rows: ");
//int rows = int.Parse(Console.ReadLine());
//
//// Turning input into number of rows
//for (int i = 1; i <= rows; i++)
//    {
//        // Turning input in number of stars
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write("*");
//        }
//    Console.WriteLine();
//    }
////////////////////////////////////////////////////

//Console.WriteLine("--- Task 3 - Generator of prime numbers ---");
//Console.Write("Enter number N: ");
//int n = int.Parse(Console.ReadLine());
//
//Console.WriteLine($"Prime numbers from 1 to {n}:");
//
// Check every prime nubmer from 2 to N
//for (int i = 2; i <= n; i++)
//{
//   bool isPrime = true; 
//
//    // Check divisors from 2 to (i-1)
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0) // If divide without leftovers
//        {
//            isPrime = false; 
//            break;           
//        }
//    }
//
//    if (isPrime == true)
//    {
//        Console.Write(i + " ");
//    }
//}
//Console.WriteLine();
//////////////////////////////////////////////////

//Console.WriteLine("--- Task 4 - Generator of Fibonnachi sequence ---");
//Console.Write("Enter amount of numbers N: ");
//int n = int.Parse(Console.ReadLine());
//
////Creating vars for next steps
//int a = 0;
//int b = 1;
//int count = 0;
//
//Console.Write("Sequence: ");
//
//// Using while and calculated every next number
//while (count < n)
//{
//    Console.Write(a + " ");
//    int next = a + b;
//    a = b;
//    b = next;
//
//    count = count + 1;
//}
//Console.WriteLine();
/////////////////////////////////////////////////////

Console.WriteLine("--- Task 5 - Calculator for salary per hour ---");

Console.Write("Enter amount of hours: ");
double hours = double.Parse(Console.ReadLine());

Console.Write("Enter rate for hour: ");
double rate = double.Parse(Console.ReadLine());

double totalPay = hours * rate;
Console.WriteLine($"Salary per day: {totalPay}");


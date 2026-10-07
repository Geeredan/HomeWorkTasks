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
//    sum += salary;
//    i = i + 1;
//}
////Outing average salary of all workers
//double average = sum / count;
//Console.WriteLine($"Average salary: {average}");
//////////////////////////////////////////////////////////////////////////////////

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
///////////////////////////////////////////////////////////////////////////////////

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
//    if isPrime
//    {
//        Console.Write(i + " ");
//    }
//}
//Console.WriteLine();
/////////////////////////////////////////////////////////////////////////////////

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
///////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("--- Task 5 - Calculator for salary per hour ---");
//Console.Write("How many hours did u work today? ");
//int totalHours = int.Parse(Console.ReadLine());

//double totalPay = 0; // Total sum of salary per day

//Console.WriteLine("\nEnter hour rate for each hour");
//Console.WriteLine("(If there was no orders enter 0, if in was any of that - enter the num)");

//// for check every hour fron 1st to the lst one
//for (int hour = 1; hour <= totalHours; hour++)
//       {
//            Console.Write($"Hour rate for {hour}th hour: ");
//            double hourlyRate = double.Parse(Console.ReadLine());

//            // Add salary for each hour to total salary per day
//            totalPay = totalPay + hourlyRate;
//        }

// // Displaying final result
//Console.WriteLine($"\n--- End of the day ---");
//Console.WriteLine($"Workhours: {totalHours}");
//Console.WriteLine($"Total salary: {totalPay:F2} грн");

/////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("--- Task 6 - Generetor of multiplication table  ---");
//Console.Write("Enter number: ");
//int num = int.Parse(Console.ReadLine());
//
//for (int i = 1; i <= 10; i++)
//{
//    int result = num * i;
//    Console.WriteLine($"{num} * {i} = {result}");
//}
////////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("--- Task 7 - Check for primary  ---");

    Console.Write("Enter number: ");
    int num = int.Parse(Console.ReadLine());

    int divisorsCount = 0;

    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            divisorsCount = divisorsCount + 1;
        }
    }
    if (divisorsCount == 2)
    {
        Console.WriteLine($"Number {num} is primary.");
    }
    else
    {
        Console.WriteLine($"Number {num} isn`t primary.");
    }
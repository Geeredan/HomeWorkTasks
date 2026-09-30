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

Console.WriteLine("--- Task 2 - Star diagram ---");
Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine());

// Turning input into number of rows
for (int i = 1; i <= rows; i++)
    {
        // Turning input in number of stars
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
    Console.WriteLine();
    }


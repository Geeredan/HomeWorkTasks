//Entering total amount of workers
Console.WriteLine("--- Task 1 - Average salary ---");
Console.Write("Enter number of staff members: ");

int count = int.Parse(Console.ReadLine());

double sum = 0;
int i = 1;

//Entering a salsry for each worker up to total amount of them
while (i <= count)
{
    Console.WriteLine($"Salary of {i} worker: ");
    double salary = double.Parse(Console.ReadLine());

    sum = sum + salary;
    i = i + 1;
}
 //Outing average salsry of all workers
double average = sum / count;
Console.WriteLine($"Average salary: {average}");

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < N)
{
    Console.WriteLine(i+1);
    i += 2;
}
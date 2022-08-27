// See https://aka.ms/new-console-template for more information
int fact(int N) {
    if (N == 1) return 1;
    fact(N - 1);
    return N * fact(N - 1);
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(fact(n));
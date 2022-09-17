// напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//1 вариант
int n =5;
for (int i = 1; i <= n; i++)
{
    System.Console.Write(i + ", ");
}
//2 вариант
string showNumbers(int N)
{
    return (N == 1 ? "1" : showNumbers(N - 1) + N);
}
System.Console.Write(showNumbers(5));
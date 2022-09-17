namespace hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumLoop(int N)
            {
                int sum=0;
                for (int i=1;i<=N;i++) sum+=i;
                return sum;
            }
            int SumRec(int N)
            {
                if (N==0) return 0;
                else return N + SumRec(N-1);
            }
            Console.WriteLine(SumLoop(2));
            Console.WriteLine(SumRec(5));
        }
    }
}
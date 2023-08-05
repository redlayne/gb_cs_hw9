internal class Program
{
    private static void Main(string[] args)
    {
        void DividedBy3Recursion(int fromN, int toM)
        {   
            if (fromN > toM) return;
            Console.Write($"{fromN} ");
            DividedBy3Recursion(fromN + 3, toM);
        }

        int SumRecursion(int fromN, int toM, int sum = 0)
        {   
            if (fromN > toM) return sum;
            sum += fromN;
            return SumRecursion(fromN + 1, toM, sum);
        }
        
        int AckermanRecursion (int m, int n) // можно было использовать лонги или даже улонги, но ведь это не сильно поможет ))
        {
            if (m == 0) return n+1;
            else if (n == 0) return AckermanRecursion(m-1, 1);
            else return AckermanRecursion (m-1, AckermanRecursion(m, n-1));
        }

        void NToMTask64()
        {
            int n = CustomLibClass.Input("Enter a number (N): ");
            int m = CustomLibClass.Input("Enter a number (M): ");
            if (n > m) CustomLibClass.Swap(ref n, ref m);
            n = n + 3 - n%3;
            DividedBy3Recursion(n, m);
        }

        void SumNMTask66()
        {
            int n = CustomLibClass.Input("Enter a number (N): ");
            int m = CustomLibClass.Input("Enter a number (M): ");
            Console.WriteLine($"Sum of numbers from {n} to {m} is {SumRecursion(n,m)}");
        }
        
        void AckermanTask68()
        {   
            int n = CustomLibClass.Input("Enter a number m: ");
            int m = CustomLibClass.Input("Enter a number n: ");
            if (n < 0 || m < 0) Console.WriteLine("n and m should be higher than 0");
            else Console.WriteLine($"A({n}, {m}) = {AckermanRecursion (n, m)}");
        }
        Console.Clear();

        NToMTask64();

        CustomLibClass.Anykey();
        CustomLibClass.Break();

        SumNMTask66();

        CustomLibClass.Anykey();
        CustomLibClass.Break();

        AckermanTask68();
    }
}
namespace CodeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
                 
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[] basket = new int[n];

            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split();
                int startBasket = int.Parse(s[0]);
                int endBasket = int.Parse(s[1]); 
                int ballNumber = int.Parse(s[2]);

                for (int j = startBasket-1; j <= endBasket-1; j++)
                {
                    basket[j] = ballNumber;
                }
            }

            for (int i = 0; i < basket.Length; i++)
            {
               Console.Write($"{basket[i]} ");

            }

        }
    }
}

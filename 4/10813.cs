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

            for (int i = 0; i < basket.Length; i++)
            {
                basket[i] = i + 1;
            }

            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split();
                int swapBasketA = int.Parse(s[0])-1;
                int swapBasketB = int.Parse(s[1])-1;
                int temp = 0;

                temp = basket[swapBasketA];
                basket[swapBasketA] = basket[swapBasketB];
                basket[swapBasketB] = temp;
            }

            for (int i = 0; i < basket.Length; i++)
            {
               Console.Write($"{basket[i]} ");

            }

        }
    }
}

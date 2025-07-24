namespace CodeExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] student = new int[30];

            for (int i = 0; i < student.Length - 2; i++)
            {
                int submit = int.Parse(Console.ReadLine().ToString()) - 1;
                student[submit] = 1;
            }

            for (int i = 0; i < student.Length; i++)
            {
                if (student[i] == 0)
                {
                    Console.WriteLine($"{i+1}");
                }
            }

        }
    }
}

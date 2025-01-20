namespace Set2Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nr de elemente din serie: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu elementele: ");
            double element;
            double sumaInvers = 0;
            for(int i = 0; i < n; i++)
            {
                element = double.Parse(Console.ReadLine());
                if(element == 0)
                {
                    Console.WriteLine("Elementul nu poate fi 0");
                    i--;
                    continue;
                }
                sumaInvers += 1 / element;
            }
            Console.WriteLine($"Suma inverselor elementelor din vector este {sumaInvers:F2}");
        }
    }
}

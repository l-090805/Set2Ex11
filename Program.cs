namespace Set2Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nr de elemente din serie: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu numerele seirie: ");
            double[] v = new double[n]; 
            for(int i = 0; i < n; i++)
            {
                v[i] = double.Parse(Console.ReadLine());   
            }

            double sumaInverselor = 0;
            for(int i = 0;i < n; i++)
            {
                sumaInverselor += 1 / v[i];
            }

            Console.WriteLine($"Suma inverselor fiecarui numar din secventa este {sumaInverselor}");
        }
    }
}

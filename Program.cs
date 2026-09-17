namespace pp
{
    public class Program
    {
        static void Main(string[] args)
        {
           Model m = new Model();
            Console.WriteLine(m.cars.Count);
            m.afterYear(2016).ForEach(x => Console.WriteLine(x));

            if (m.Van("BMW"))
            {
                Console.WriteLine("v");
            }
            else
            {
                Console.WriteLine("n");
            }
        }
        
    }
}

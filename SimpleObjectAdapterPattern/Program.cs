namespace SimpleObjectAdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adaptor();
            Console.WriteLine(target.SampleMethod(5));
        }
    }
}
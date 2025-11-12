namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzService fizzBuzzService = new FizzBuzzService();
            var results = fizzBuzzService.GetFizzBuzzResult();
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

        }
    }
}

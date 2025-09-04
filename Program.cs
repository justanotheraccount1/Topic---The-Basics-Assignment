namespace Topic___The_Basics_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Sam";
            string favMovie = "The Matrix";
            Console.WriteLine($"hello, {firstName.ToLower()}. the best movie is {favMovie.ToLower()}");
            favMovie = favMovie.ToUpper();
        }
    }
}

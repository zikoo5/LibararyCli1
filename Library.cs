namespace Kys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(("Hello There,please write the book you want its information :"));
            //unput the book name
            string name = Console.ReadLine();
            //book number
            Console.WriteLine("Book Number is : " + name.Substring(0, 4));
            //book title
            Console.WriteLine("Book Title is : " + name.Substring(4, name.Length - 7));
            //book type
            Console.WriteLine("Book Type is : " + name.Substring(name.Length - 3, 3));

            Console.ReadKey();
        }
    }
}


namespace ConsoleApp4git
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> list = new List<string>();
            list.Add("java");
            list.Add("asdfa");
            list.Add("c#");
            list.Add("C++");
            list.Add("C");
            list.Add("python");
            list.Add("nobe");
            list.Add("nvso");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

namespace datastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  int []arr = new int[5];
            //  arr[0] = 100;
            //  arr[4] = 1000;
            //arr[^1] = 1000;
            // Console.WriteLine(arr[0]);
            //  Console.WriteLine(arr[4]);
            //  Console.WriteLine(arr[^1]);
            // Console.WriteLine(arr[2]);

            List<int> mylist = new List<int>();
           // mylist[0] = Convert.ToInt32(Console.ReadLine()); wrongway
            mylist.Add ( Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(mylist[0]);











        }
    }
}

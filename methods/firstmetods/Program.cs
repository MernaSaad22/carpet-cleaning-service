namespace firstmetods
{
    internal class Program
    {
        static void Calculator(int x,int y,string op)
        {
            // int x=Convert.ToInt32(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine(x + y);

            }
            else if (op == "-")
            {
                Console.WriteLine(x - y);
            }
            else if (op == "*")
            {
                Console.WriteLine(x * y);
            }
            else if (op == "/")
            {
                Console.WriteLine(x / y);
            }
            else
            {
                Console.WriteLine("please enter an operator such as + or - or * or /");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the firest number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the operator");
            string key=Console.ReadLine();
            Calculator(num1,num2,key);



        }
    }
}

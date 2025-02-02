using System.Security.Cryptography.X509Certificates;

namespace Player
{
    class Playerr
    {
        public string Name { get; set; }
        public int Health {  get; set; }

        public double Experince {  get; set; }

        public Playerr(string name="none", int health=0, double experince=0)
        {
            Name = name;
            Health = health;
            Experince = experince;
        }

        public string Shoot()
        {
            return Name + " is shooting";
        }
        public string Trow()
        {
            return Name+" is trowing";
        }
        public string Pass(Playerr p1)
        {
            return Name + " "  +"is passing ball to "+ p1.Name;
        }
        public static Playerr operator+(Playerr lhs, Playerr rhs)
        {
            return (new Playerr(lhs.Name + " " + rhs.Name, lhs.Health + rhs.Health, lhs.Experince + rhs.Experince));
        }
        public static Playerr operator++(Playerr p1)
        {
            
            return (new Playerr(p1.Name.ToUpper(), ++p1.Health, ++p1.Experince));
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Playerr a1 = new("maged", 30, 20.5);
            Playerr a2 = new("merna", 50, 2.5);
            Playerr a3 = a2 + a1;
            Console.WriteLine(a3.Name); 
            Console.WriteLine(a3.Health);
            Console.WriteLine(a3.Experince);
            Playerr b1 = ++a3;
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Health);
            Console.WriteLine(b1.Experince);

            // Console.WriteLine( a1.Shoot());
            // Console.WriteLine(a1.Trow());
            // Console.WriteLine(a1.Pass(a2));
        }
    }
}

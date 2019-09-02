using System;

namespace HashCodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ren r1 = new ren();
            ren r2 = new ren();
            r1.age = 1;
            r1.name = "1";
            r2.age = 1;
            r2.name = "1";
            Console.WriteLine($"r1的哈希值{r1.GetHashCode()}");
            Console.WriteLine($"r2的哈希值{r2.GetHashCode()}");


            wu r3 = new wu();
            r3.age = 1;
            r3.name = "1";

            wu r4 = new wu();
            r4.age = 1;
            r4.name = "1";
          
            Console.WriteLine($"r3的哈希值{r3.GetHashCode()}");
            Console.WriteLine($"r4的哈希值{r4.GetHashCode()}");
            Console.ReadKey();
        }
    }
    public class wu
    {
        public int age { get; set; }
        public string name { get; set; }
    }
    public class ren
    {
        public int age { get; set; }
        public string name { get; set; }
        public override bool Equals(object obj)
        {
            var ren = obj as ren;
            return ren != null &&
                   age == ren.age &&
                   name == ren.name;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(age, name);
        }
    }
}

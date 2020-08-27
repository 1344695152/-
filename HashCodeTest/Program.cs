using System;

namespace HashCodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ren r1 = new ren();
            r1.age = 2;
            r1.name = "的撒赫迪拉杀伤距离";
            Console.WriteLine($"r1的哈希值{r1.GetHashCode()}");

            ren r2 = new ren();
            r2.age = 2;
            r2.name = "的撒赫迪拉杀伤距离";
            Console.WriteLine($"r2的哈希值{r2.GetHashCode()}");

            wu r3 = new wu();
            r3.age = 1;
            r3.name = "的撒赫迪拉杀伤距离";
            Console.WriteLine($"r3的哈希值{r3.GetHashCode()}");

            wu r4 = new wu();
            r4.age = 1;
            r4.name = "的撒赫迪拉杀伤距离";
            Console.WriteLine($"r4的哈希值{r4.GetHashCode()}");

            string test1 = JsonConvert.SerializeObject(r3);
            Console.WriteLine($"r3json的哈希值{test1.GetHashCode()}");

            string test2 = JsonConvert.SerializeObject(r4);
            Console.WriteLine($"r4json的哈希值{test2.GetHashCode()}");

            r4.age = 0;
            string test3 = JsonConvert.SerializeObject(r4);
            Console.WriteLine($"r4改值后json的哈希值{test3.GetHashCode()}");
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

using System;
using System.Data.Entity;

namespace ConsoleApp
{
    public class Context:DbContext
    {
        public DbSet<cliente> cliente { get; set; }
    }

   

    public class cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

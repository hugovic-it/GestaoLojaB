using GestaoLojaConsole.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace GestaoLojaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Configuração do DbContextOptions para SQLite
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite("Data Source=Banco.db");

            Console.WriteLine("Olár, mundo!");



        }
    }
}
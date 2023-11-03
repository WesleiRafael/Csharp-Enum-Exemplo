using CursoCsharp.Entities;
using CursoCsharp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            string departamentoNome = Console.ReadLine();
            Console.WriteLine("Data do trabalho:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel: (Junior/Pleno/Senior): ");
            string nivelStr = Console.ReadLine();
            NivelTrabalhador nivel = (NivelTrabalhador)Enum.Parse(typeof(NivelTrabalhador), nivelStr, true);
            Console.Write("Base salarial: ");
            double baseSalarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dept = new Departamento(departamentoNome);
            Trabalhador trabalhador = new Trabalhador(nome, nivel, baseSalarial, dept);

            Console.Write("quantos contratos para esse trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com o #{i} contrato, Data:");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());
                HorasContrato contract = new HorasContrato(date, valuePerHour, hours);
                trabalhador.AdicionaContrato(contract);
            }

            Console.WriteLine();
            Console.Write("Entre com o mês e Ano que deseja calcular o ganho (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Nome : " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Ganho em " + monthAndYear + " foi de: " + trabalhador.Ganho(year, month).ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}

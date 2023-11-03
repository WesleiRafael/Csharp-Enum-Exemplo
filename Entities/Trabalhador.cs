using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.Entities.Enums;

namespace CursoCsharp.Entities
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Pleno { get; set; }
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }
        public List<HorasContrato> Contratos { get; set; } = new List<HorasContrato>();


        public Trabalhador()
        {
        }

        public Trabalhador(string nome, NivelTrabalhador pleno, double baseSalario, Departamento departamento)
        {
            Nome = nome;
            Pleno = pleno;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }

        public void AdicionaContrato(HorasContrato contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemoveContrato(HorasContrato contrato)
        {
            Contratos.Remove(contrato);
        }
        public double Ganho(int Ano, int mes)
        {
            double soma= BaseSalario;

            foreach (HorasContrato contrato in Contratos)
            {
                if (contrato.Date.Year == Ano && contrato.Date.Month == mes)
                {
                    soma += contrato.TotalValor();
                }
            }
            return soma;

            
        }
    }
}





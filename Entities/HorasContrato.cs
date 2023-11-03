using System;


namespace CursoCsharp.Entities
{
    class HorasContrato
    {
        public DateTime Date { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }
    
        public HorasContrato() 
        {
        }

        public HorasContrato(DateTime date, double valorPorHora, int horas)
        {
            Date = date;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double TotalValor()
        {
            return Horas*ValorPorHora;
        }
    }
}

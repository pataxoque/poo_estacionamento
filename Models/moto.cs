using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_1.Veículos;

namespace POO_1
{
    public class Moto : Veiculos
    {
          private const decimal TaxaPrimeiraHora = 7.00m;
        private const decimal TaxaHoraAdicional = 3.00m;

        public Moto (string placa, string marca, string modelo)
        : base(placa, marca, modelo) {}
         public override decimal CalcularCobranca(DateTime horaSaida)
{
    double horasTotais = (horaSaida - HoraEntrada).TotalHours;

    if (horasTotais <= 1)
        return TaxaPrimeiraHora;

    int horasAdicionais = (int)Math.Ceiling(horasTotais - 1);
    return TaxaPrimeiraHora + (horasAdicionais * TaxaHoraAdicional);
}
        public override void ExibirInfo()
        {
            Console.WriteLine("Tipo : Moto");
            base.ExibirInfo();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_1.Veículos;

namespace POO_1
{
    public class Carro : Veiculos
    {
        private const decimal TaxaPrimeiraHora = 12.00m;
        private const decimal TaxaHoraAdicional = 3.00m;

        public Carro (string placa, string marca, string modelo)
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
        Console.WriteLine("  Tipo   : Carro");
        base.ExibirInfo();
    }

    }
    
    
}
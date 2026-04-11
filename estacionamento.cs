using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using POO_1.Veículos;

namespace POO_1
{
    public class Estacionamento
    {
        private List<Veiculos> _veiculos = new List<Veiculos>();

        public void RegistrarEntrada(Veiculos veiculo)
        {
            _veiculos.Add(veiculo);
            Console.WriteLine("Veículo cadastrado! ✅");
            veiculo.ExibirInfo();
        }
        
        public void RegistrarSaida(string placa, DateTime? horaSaida = null)
        {
            var veiculo = _veiculos.Find(v => v.Placa == placa.ToUpper());

                if (veiculo == null)
                throw new Exception("Veículo não encontrado."); 

                DateTime saida = horaSaida ?? DateTime.Now;
                decimal total = veiculo.CalcularCobranca(saida);
                _veiculos.Remove(veiculo);
        }
        

        
        
       
    }
}
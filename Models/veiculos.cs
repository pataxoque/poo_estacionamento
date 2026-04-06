using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace POO_1.Veículos
{
    public abstract class Veiculos
    {
        private string _placa;
        private string _marca;
        private string _modelo;
        private DateTime _horaEntrada;

        public string Placa
        {
            get => _placa;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Placa inválida.");
                _placa = value.ToUpper();
            }
        }

        public string Marca
        {
            get => _marca;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Marca inválida.");
                _marca = value.ToUpper();
            }
        }
        public string Modelo
        {
            get => _modelo;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Modelo inválido.");
                _modelo = value.ToUpper();
            }
        }

        public DateTime HoraEntrada
        {
            get => _horaEntrada;
            private set => _horaEntrada = value;
        }    
     protected Veiculos(string placa, string marca, string modelo)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
        HoraEntrada = DateTime.Now; // registra a hora automaticamente
    }

    // Método abstrato — cada veículo DEVE implementar o seu
    public abstract decimal CalcularCobranca(DateTime horaSaida);

    // Método virtual — pode ser sobrescrito nas filhas
     public virtual void ExibirInfo()
        {
        Console.WriteLine($"  Placa  : {Placa}");
        Console.WriteLine($"  Marca  : {Marca}");
        Console.WriteLine($"  Modelo : {Modelo}");
        Console.WriteLine($"  Entrada: {HoraEntrada:dd/MM/yyyy HH:mm:ss}");
        }
    }
}
using System.Security.Cryptography.X509Certificates;
using POO_1;


var Estacionamento = new Estacionamento();

//SIMULACÃO — descomente para testar, ele já irá remover o carro automaticamente com o ticket.
//Estacionamento.RegistrarEntrada(new Carro("ABC1234", "Toyota", "Corolla"));
//DateTime horaSimulada = DateTime.Now.AddHours(2);
//Estacionamento.RegistrarSaida("ABC1234", horaSimulada);


while (true)
{
    // menu aqui dentro!
    Console.WriteLine("=== ESTACIONAMENTO ===");
    Console.WriteLine("1 - Registrar entrada");
    Console.WriteLine("2 - Registrar saída");
    Console.WriteLine("3 - Sair");
    Console.Write("Escolha: ");

    // leitura aqui dentro também!
    int opcao;
    bool valido = int.TryParse(Console.ReadLine(), out opcao);

    if (!valido)
    {
        Console.WriteLine("Digite um número válido.");
        continue; // volta pro início do while
    }

    switch (opcao)
    {
        case 1:
         Console.WriteLine("1 - Carro");
    Console.WriteLine("2 - Moto");
    Console.Write("Tipo: ");
    int tipo;
    int.TryParse(Console.ReadLine(), out tipo);

    Console.Write("Placa: ");
    string placa = Console.ReadLine();

    Console.Write("Marca: ");
    string marca = Console.ReadLine();

    Console.Write("Modelo: ");
    string modelo = Console.ReadLine();

      if (tipo == 1)
                Estacionamento.RegistrarEntrada(new Carro(placa, marca, modelo));
            else if (tipo == 2)
                Estacionamento.RegistrarEntrada(new Moto(placa, marca, modelo));
            break;

            
        case 2:
       Console.Write("Informe a placa do veículo: ");
    string placaSaida = Console.ReadLine(); // 👈 guarda na variável

    try
    {
        Estacionamento.RegistrarSaida(placaSaida); // 👈 chama o método
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}"); // 👈 trata se não encontrar
    }
    break;

        case 3:
            Console.WriteLine("Encerrando...");
            return; 
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}




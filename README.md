# Sistema de Gestão de Estacionamento

Projeto desenvolvido em C# com Orientação a Objetos como exercício prático aplicando abstração, herança, encapsulamento e polimorfismo.

---

## Estrutura do Projeto

```
POO_1/
│
├── Veículos/
│   └── Veiculo.cs          # Classe base abstrata
│
├── Carro.cs                # Herda de Veiculo
├── Moto.cs                 # Herda de Veiculo
├── Estacionamento.cs       # Lógica do sistema
└── Program.cs              # Ponto de entrada
```

---

## Conceitos de POO Aplicados

**Abstração** — A classe `Veiculo` é abstrata e não pode ser instanciada diretamente, apenas através de `Carro` e `Moto`.

**Encapsulamento** — Os dados `_placa`, `_marca` e `_modelo` são campos privados acessados apenas via propriedades com validação.

**Herança** — `Carro` e `Moto` herdam de `Veiculo`, reaproveitando atributos e comportamentos comuns.

**Polimorfismo** — O método `CalcularCobranca` é implementado de forma diferente em cada classe filha, calculando o valor correto automaticamente conforme o tipo do veículo.

---

## Tarifas

| Veículo | Primeira Hora | Hora Adicional |
|---------|--------------|----------------|
| Carro   | R$ 12,00     | R$ 3,00        |
| Moto    | R$ 7,00      | R$ 3,00        |

---

## Como Rodar

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/) instalado
- Visual Studio Code com extensões C# e C# Dev Kit

### Executando

```bash
git clone https://github.com/seu-usuario/POO_1.git
cd POO_1
dotnet run
```

---

## Simulação de Testes

Para testar o cálculo sem esperar horas reais, descomente as linhas no `Program.cs`:

```csharp
// Estacionamento.RegistrarEntrada(new Carro("ABC1234", "Toyota", "Corolla"));
// DateTime horaSimulada = DateTime.Now.AddHours(2);
// Estacionamento.RegistrarSaida("ABC1234", horaSimulada);
```

Resultado esperado com 2 horas para um carro:
```
Total: R$ 15,00
```

---

## Exemplo de Ticket

```
========== TICKET DE SAÍDA ==========
  Tipo   : Carro
  Placa  : ABC1234
  Marca  : Toyota
  Modelo : Corolla
  Entrada: 01/01/2024 10:00:00
  Saída  : 01/01/2024 12:30:00
  Total  : R$ 18,00
======================================
```
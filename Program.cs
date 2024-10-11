using System.Collections;
using Desafio_Estacionamento.models;

Estacionamento estacionamento = new();

List<string> veiculos = new();
string placa;
estacionamento.Veiculos = veiculos; 

Console.WriteLine("Antes de acessar os veículos defina alguns parametros...\n\nDigite o valor fixo do estacionamento: ");
estacionamento.ValorFixo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de cada hora do carro estacionado: ");
estacionamento.HorasEstacionadas = Convert.ToInt16(Console.ReadLine());
Console.Clear();

bool continua = true;

while(continua) {
  Console.WriteLine("""
  Bem vindo ao estacionamento...

  [1] - Adicionar veículo;
  [2] - Remover veículo;
  [3] - Listar veículos;
  [4] - Encerrar Programa;
  """);

  string opcao = Console.ReadLine();

  switch (opcao)
  {
    case "1":
      Console.WriteLine("Digíte a placa do veículo que você quer adicionar:");
      placa = Console.ReadLine();
      estacionamento.AddVeicles(placa);
      break;
    case "2":
      Console.WriteLine("Digite a placa do veículo que você quer retirar");
      placa = Console.ReadLine();
      estacionamento.RemoveVeicles(placa);
      break;
    case "3":
      estacionamento.ShowVeicles();
      break;
    default:
      continua = false;
      break;
  }
}




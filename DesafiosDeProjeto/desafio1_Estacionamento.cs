using System;
using System.Collections.Generic;
using System.Linq;

public class Estacionamento
{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }
    
    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine().ToUpper();
        
        // Verifica se o veículo já está estacionado
        if (veiculos.Contains(placa))
        {
            Console.WriteLine("Veículo já está estacionado.");
        }
        else
        {
            veiculos.Add(placa);
            Console.WriteLine($"Veículo {placa} estacionado com sucesso!");
        }
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = Console.ReadLine().ToUpper();

        if (veiculos.Contains(placa))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int horas = Convert.ToInt32(Console.ReadLine());

            decimal valorTotal = precoInicial + precoPorHora * horas;

            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
//Fim classe Estacionamento


//Inicio classe Program
class Program
{
    static void Main()
    {
        // Coloca o encoding para UTF8 para exibir acentuação
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        decimal precoInicial = 0;
        decimal precoPorHora = 0;
        
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                          "Digite o preço inicial:");
        precoInicial = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("Agora digite o preço por hora:");
        precoPorHora = Convert.ToDecimal(Console.ReadLine());
        
        // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
        Estacionamento es = new Estacionamento(precoInicial, precoPorHora);
        
        string opcao = string.Empty;
        bool exibirMenu = true;
        
        // Realiza o loop do menu
        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
        
            switch (Console.ReadLine())
            {
                case "1":
                    es.AdicionarVeiculo();
                    break;
        
                case "2":
                    es.RemoverVeiculo();
                    break;
        
                case "3":
                    es.ListarVeiculos();
                    break;
        
                case "4":
                    exibirMenu = false;
                    break;
        
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }
        
        Console.WriteLine("O programa se encerrou");
    }
    
}

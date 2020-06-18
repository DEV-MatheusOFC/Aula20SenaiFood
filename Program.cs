using System;

namespace Aula_20___SenaiFood
{
    class Program
    {
        static void Main(string[] args)
        {       
            Restaurante info = new Restaurante();
            info.Nome = "Cantina do Senai";
            info.Endereco = "Alameda Barão de Limeira, 539 - Santa Cecilia, São Paulo - SP, 01202-001";
            info.MostrarDados();

            //
            Cliente cliente = new Cliente();
            cliente.NomeC = "Matheus";
            cliente.EnderecoC = "Av. Paulista, 523.";

            string resposta = null;

            while(resposta != "Sim"){
            cliente.MostrarDadosC();
            resposta = Console.ReadLine();
            }

            //
            Pedido Esfiha = new Pedido("Esfihas", "Sabores: Carne/Calabresa/Queijo", "Preço: R$3");
            System.Console.WriteLine($"\n{Esfiha.Nome}\n{Esfiha.Descricao}\n{Esfiha.Preco}");
        }
    }
}

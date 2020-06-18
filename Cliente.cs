namespace Aula_20___SenaiFood
{
    public class Cliente
    {
        public string NomeC { get; set; }
        public string EnderecoC { get; set; }
        public string resposta;

        public void MostrarDadosC(){
            System.Console.WriteLine($"\nConfirme seus dados: \nNome: {NomeC} \nEndereço de Entrega: {EnderecoC} \nResponda com Sim ou Nao.");
        }
    }
}
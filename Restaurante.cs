namespace Aula_20___SenaiFood
{
    public class Restaurante
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public void MostrarDados(){
            System.Console.WriteLine($"Informações do Restaurante: \n{Nome} \n{Endereco}");
        }
    }
}
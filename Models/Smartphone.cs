namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Memoria = memoria;
            // Implementado!!
        }

        public string Numero { get; set; }
        // Implementado!!
        private string Modelo { get; set; }

        private int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
namespace DesafioPOO.Models
{
    //Implementado!
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, int memoria) : base(numero, modelo, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo {nomeApp} foi instalado com sucesso");
        }
        //Implementado
    }
}
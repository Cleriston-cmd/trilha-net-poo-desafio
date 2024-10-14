namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        //Implementando as propriedades de acordo com o diagrama
        private string Modelo {get; set; }
        private string IMEI {get; set; }
        private int Memoria {get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {   // Passando os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

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
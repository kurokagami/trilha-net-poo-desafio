namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string Numero, string Modelo, string IMEI, int Memoria) : base (Numero, Modelo, IMEI, Memoria){}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} em seu {Modelo}");
        }
        public override void Informações(){
            Console.WriteLine($"Informações do Celular\nNumero: {Numero} \nModelo: {Modelo} \nIMEI: {IMEI} \nMemoria: {Memoria}");
        }
    }
}
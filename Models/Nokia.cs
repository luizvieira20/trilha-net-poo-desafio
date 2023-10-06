namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome){
            Console.WriteLine($"App {nome} instalado no Nokia!");
        }

        public Nokia(string numero, string modelo, string imei, int memoria):base(numero, modelo, imei, memoria){}
    }
}
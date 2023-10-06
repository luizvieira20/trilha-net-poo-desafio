namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome){
            Console.WriteLine($"App {nome} instalado no iPhone!");
        }

        public Iphone(string numero, string modelo, string imei, int memoria):base(numero, modelo, imei, memoria){

        }
    }
}
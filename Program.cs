using DesafioPOO.Models;

class Program
{
        
static void Main(string[] args)
        
    {
        Console.WriteLine("Smartphone Nokia");
        Smartphone nokia = new Nokia(numero: "1234560", modelo: "0104", imei: "11111111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("whatssapp");


        Console.WriteLine("\n");


        Console.WriteLine("Smartphone Iphone");
        Smartphone iphone = new Iphone(numero: "326565", modelo: "2240", imei: "22222222", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }

}
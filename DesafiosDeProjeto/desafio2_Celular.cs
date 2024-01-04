using System;

// Início classe Smartphone
public abstract class Smartphone
{
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string IMEI { get; set; }
    private string Memoria { get; set; }

    public Smartphone(string numero, string modelo, string imei, string memoria)
    {
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
//Fim classe Smartphone

//Inicio classe Nokia
public class Nokia : Smartphone
{
    // Adicionando construtor
    public Nokia(string numero, string modelo, string imei, string memoria)
        : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando {nomeApp} no Nokia...");
    }
}
//Fim classe Nokia

//Inicio classe Iphone
public class Iphone : Smartphone
{
    // Adicionando construtor
    public Iphone(string numero, string modelo, string imei, string memoria)
        : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando {nomeApp} no iPhone...");
    }
}
//Fim classe Iphone

//Program
class Program
{
    static void Main()
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: "64");
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222", memoria: "128");
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}

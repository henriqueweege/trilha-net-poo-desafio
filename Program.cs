using DesafioPOO.Models;

public class Program
{
   static void Main() 
   {
        string numero = "numero"; 
        string modelo = "modelo";
        string imei = "imei";
        int memoria = 1;

        var nokia = new Nokia(numero, modelo, imei, memoria);
        nokia.InstalarAplicativo("");

        Console.WriteLine($"nokia numero {nokia.Numero}");   
        Console.WriteLine($"nokia modelo {nokia.Modelo}");   
        Console.WriteLine($"nokia IMEI {nokia.IMEI}");   
        Console.WriteLine($"nokia memoria {nokia.Memoria}");   


        var iphone = new Iphone(numero, modelo, imei, memoria);
        iphone.InstalarAplicativo("");

        Console.WriteLine($"iphone numero {nokia.Numero}");   
        Console.WriteLine($"iphone modelo {nokia.Modelo}");   
        Console.WriteLine($"iphone IMEI {nokia.IMEI}");   
        Console.WriteLine($"iphone memoria {nokia.Memoria}");
   }
}
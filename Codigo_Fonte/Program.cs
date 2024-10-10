using System;
public class Program
{
    private const string V = "110";

    public static void Main()
	{
        string a1, b1, c1;
        Console.WriteLine("Entre com o estado da boia A, B e C em sequência (0para inativa e true para 1)");
        a1 = Console.ReadLine();
        b1 = Console.ReadLine();
        c1 = Console.ReadLine();
        if ((a1 == "0" ||a1 == "1")&&(b1 == "0" ||b1 == "1")&&(c1 == "0" ||c1 == "1"))
        {
            string boias = a1 + b1 + c1;
            switch (boias)
            {
                case "000": 
                case "011":
                case "111":
                 Console.WriteLine("Bomba e eletroválvula ativadas");
                 break;
                case "001":
                 Console.WriteLine("Bomba ativada e eletroválvula desativada");
                break;
                case "010":
                case "110":
                 Console.WriteLine("Bomba desativada e eletroválvula ativada");
                break;
                default:
                 Console.WriteLine("Condição impossivel.");
                break;
            }
        }else
        Console.WriteLine("Só é aceito 'True' e 'False' como valores.");
	}
}
public static class Exercicio6
{
    public static void Executar()
    {
        string diaSemana;
        double temperatura;
        string hora;

        Console.Write("Que dia da semana é hoje? ");
        diaSemana = Console.ReadLine()!;

        Console.Write("Qual a temperatura agora (em °C)? ");
        temperatura = double.Parse(Console.ReadLine()!);

        Console.Write("Que horas são agora? ");
        hora = Console.ReadLine()!;

        Console.WriteLine();
        Console.WriteLine($"Hoje é {diaSemana}, está fazendo {temperatura} °C e agora são {hora} horas.");

    }
}
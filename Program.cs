Random random = new Random();
bool jogarDenovo = true;
int min = 1;
int max = 100;
int guess;
int num;
int guesses;
String resposta;

while (jogarDenovo)
{
    guess= 0;
    guesses = 0;
    resposta = "";
    num = random.Next(min, max + 1);

    while (guess != num)
    {
        Console.WriteLine("Advinhe o número secreto entre " + min + " - " + max + ": ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Advinhação: " + guess);

        if (guess > num)
        {
            Console.WriteLine(guess + " O número secreto é menor!");
        }
        else if (guess < num)
        {
            Console.WriteLine(guess + " O número secreto é maior!");
        }
        guesses++;
    }
    Console.WriteLine("Número: " + num);
    Console.WriteLine("Você advinhou!");
    Console.WriteLine("Tentativas: " + guesses );

    Console.WriteLine("Gostaria de jogar novamente? (Y/N): ");
    resposta = Console.ReadLine();
    resposta = resposta.ToUpper();

    if (resposta == "Y")
    {
        jogarDenovo = true;
    }
    else
    {
        jogarDenovo = false;
    }
}

Console.WriteLine("Obrigado por jogar!");
Console.ReadKey();

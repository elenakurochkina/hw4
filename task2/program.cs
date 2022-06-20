//Напишите программу, которая принимает на вход число и выдаёт сумму 
//цифр в числе.

int prompt(string message)
{
    System.Console.WriteLine(message);
    string number = Console.ReadLine();
    int a = int.Parse(number);
    return a;
}

int a = prompt("enter number: ");
int SumA(int maxNumber)
{
    int answer = 0;
    while (a > 0)
    {
        answer += a % 10;
        a = a / 10;
    }
    return answer;
}
System.Console.WriteLine($"Sum {SumA(a)}");
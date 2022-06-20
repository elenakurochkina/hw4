//Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B

int Prompt(string message)
{
    System.Console.Write(message);
    string x = Console.ReadLine();
    return int.Parse(x);
}
int A = Prompt("enter number A: ");
int B = Prompt("enter number B: ");

int Mult(int AB)
{
    int answer = 1;
    for (int i = 1; i <= B; i++)
    {
        answer *= A;
    }
    return answer;
}

System.Console.WriteLine($"result = {Mult(A)}");

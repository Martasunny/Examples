int GetSum(int number1, int number2)
{
    return number1 + number2;
}

int inputNumber1 = Convert.ToInt32(Console.ReadLine());
int inputNumber2 = Convert.ToInt32(Console.ReadLine());
int result = GetSum(inputNumber1, inputNumber2);

Console.WriteLine(result);

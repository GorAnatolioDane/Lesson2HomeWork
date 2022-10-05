Console.WriteLine("Введите число ");
int userNumber = Convert.ToInt32(Console.ReadLine());

void secondDigit (int userNumber)
{

if (userNumber > 99 && userNumber < 1000)
{
    int lastNumber = userNumber / 10;
    int secondNumber = lastNumber % 10;
    Console.WriteLine($"Вторая цифра числа {userNumber} равна {secondNumber}"); 
}
else    
{
    Console.WriteLine("Чилсло не трёхзначное");
}
}
secondDigit(userNumber);
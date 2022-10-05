Console.WriteLine("Введите число ");
int userNumber = Convert.ToInt32(Console.ReadLine());

void thirdDigit (int userNumber)
{

if (userNumber > 99 && userNumber < 1000)
{
    int lastNumber = userNumber % 10;
    Console.WriteLine($"Третья цифра числа {userNumber} равна {lastNumber}"); 
}
else    
{
    Console.WriteLine("Число не трёхзначное");
}
}
thirdDigit(userNumber);
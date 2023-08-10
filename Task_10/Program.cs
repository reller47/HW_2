Console.Write("Введите трёхзначное число = ");
int numeric = Convert.ToInt32(Console.ReadLine());
if (numeric  > 999){
    Console.WriteLine("\nОШИБКА ! Число не трёхзначное.");
}
else{
    numeric = numeric % 100;
    numeric = numeric / 10;
    Console.WriteLine("\nВторая цифра = " + numeric);
}
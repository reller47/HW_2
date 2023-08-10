Console.Write("Введите число = ");
int numeric = Convert.ToInt32(Console.ReadLine());
int index = 10;
int size = 0;
if (numeric < 100){
    Console.WriteLine("Третьей цифры нет.");
}
else{
    while ((numeric / index) != 0){
        index = index * 10;
    }
    size = index / 1000;
    numeric = numeric / size;
    numeric = numeric % 10;
    Console.WriteLine(numeric);
}
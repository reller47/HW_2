Console.Write("Введите число = ");
int numeric = Convert.ToInt32(Console.ReadLine());
if ((numeric < 1) || (numeric > 7)){
    Console.WriteLine("\nОШИБКА !");
}
else{
    switch (numeric){
        case 1:
            Console.WriteLine("\nПонедельник.");
            break;
        case 2:
            Console.WriteLine("\nВторник.");
            break;
        case 3:
            Console.WriteLine("\nСреда.");
            break;
        case 4:
            Console.WriteLine("\nЧетверг.");
            break;
        case 5:
            Console.WriteLine("\nПятница.");
            break;
        case 6:
            Console.WriteLine("\nСуббота. ВЫХОДНОЙ !");
            break;
        case 7:
            Console.WriteLine("\nВоскресенье. ВЫХОДНОЙ !");
            break;
        default:
            Console.WriteLine("\nОШИБКА !");
            break;
    }
}
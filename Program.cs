// See https://aka.ms/new-console-template for more information

using static System.Net.Mime.MediaTypeNames;

while (true)
{
    int qFloor=0, qEntrance=0, numFlat=0;

    Console.Write("По введенному номеру квартиры определяется номер подъезда и этажа, где находится эта квартира,а также положение квартиры на лестничной площадке: \n\n");
    while (true)
    {
        Console.Write("Введите количество этажей: ");
        if (int.TryParse(Console.ReadLine(), out qFloor) && (qFloor > 0))
            break;
        Console.WriteLine("Введите корректное значение количества этажей.");
    }


    while (true)
    {
        Console.Write("Введите количество подъездов: ");
        if (int.TryParse(Console.ReadLine(), out qEntrance) && (qEntrance > 0))
            break;
        Console.WriteLine("Введите корректное значение количества подъездов.");
    }


    while (true)
    {
        Console.Write("Введите номер квартиры: ");
        if (int.TryParse(Console.ReadLine(), out numFlat) && (numFlat > 0))
            break;
        Console.WriteLine("Введите корректное значение количества подъездов.");
    }
    int qFloorFlat = qFloor * 4;
    int qFlat = qFloorFlat * qFloor * qEntrance;

    if (numFlat > qFlat)
    {
        Console.WriteLine("Квартиры с таким номером в доме нет");
    }
    else
    {

        int numEntrance = 1 + (numFlat - 1) / qFloorFlat;
        int numFloor = 1 + ((numFlat - 1) % qFloorFlat) / 4;

        do
        {
            numFlat = numFlat - 4;
        }
        while (numFlat > 4);
        string answ;

        answ = (numFlat == 1 || numFlat == -3) ? "Ближняя слева " : (numFlat == 2 || numFlat == -2) ? "Дальняя слева " : (numFlat == 3 || numFlat == -1) ? "Дальняя справа " : (numFlat == 4 || numFlat == 0) ? "Ближняя справа " : "Ошибка ";
        Console.Write("Положение квартиры: ");
        Console.Write(answ);
        Console.Write("\n");
        Console.Write("Номер подъезда: ");
        Console.Write(numEntrance);
        Console.Write("\n");
        Console.Write("Номер этажа: ");
        Console.Write(numFloor);
        Console.Write("\n");
        //Console.Write("Вывод: ");
        //Console.Write(numFlat);
    }
    Console.Write("\n");
    Console.Write("Хотите продолжить нажмите любую клавишу \n");    
    Console.Write("Хотите выйти нажмите Q \n");
    
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    if (keyInfo.Key == ConsoleKey.Q)
        break;
    
}

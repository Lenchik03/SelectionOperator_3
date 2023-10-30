//задача 2

//int.TryParse(Console.ReadLine(), out int chislo);
//int posle = 0;

//double cifra = chislo % 10;


//switch(cifra)
//{ 
//    case 1:
//    case 9:
//        posle = 1; break;
//    case 2:
//    case 8:
//        posle = 4; break;
//    case 3:
//    case 7:
//        posle = 9; break;
//    case 4:
//    case 6:
//        posle = 6; break;
//    case 5:
//        posle = 5; break;
//    case 0:
//        posle = 0; break;
//}

//Console.WriteLine(posle);    

//задание 4
//Console.WriteLine("Введите число");
//int.TryParse(Console.ReadLine(), out int chislo);

//switch (chislo)
//{
//    case 0:
//        Console.WriteLine("zero"); break;
//    case 1:
//        Console.WriteLine("one"); break;
//    case 2:
//        Console.WriteLine("two"); break;
//    case 3:
//        Console.WriteLine("three"); break;
//    case 4:
//        Console.WriteLine("four"); break;
//        case 5:
//        Console.WriteLine("five"); break;
//        case 6:
//        Console.WriteLine("six"); break;
//    case 7:
//        Console.WriteLine("seven"); break;
//        case 8:
//        Console.WriteLine("eight"); break;
//        case 9:
//        Console.WriteLine("nine"); break;
//}


//задание 5
//Console.WriteLine("Введите число");
//int.TryParse(Console.ReadLine(), out int chislo);

//switch (chislo)
//{
//    case 1:
//        Console.WriteLine("январь"); break;
//    case 2:
//        Console.WriteLine("февраль"); break;
//    case 3:
//        Console.WriteLine("март"); break;
//    case 4:
//        Console.WriteLine("апрель"); break;
//    case 5:
//        Console.WriteLine("май"); break;
//    case 6:
//        Console.WriteLine("июнь"); break;
//    case 7:
//        Console.WriteLine("июль"); break;
//    case 8:
//        Console.WriteLine("август"); break;
//    case 9:
//        Console.WriteLine("сентябрь"); break;
//        case 10:
//        Console.WriteLine("октябрь"); break;
//    case 11:
//        Console.WriteLine("ноябрь"); break;
//    case 12:
//        Console.WriteLine("декабрь"); break;
//}

//задание 6
//Console.WriteLine("Введите оценку");
//int.TryParse(Console.ReadLine(), out int ocenka);

//switch (ocenka)
//{
//    case 1:
//        Console.WriteLine("плохо"); break;
//    case 2:
//        Console.WriteLine("неудовлетворительно"); break;
//    case 3:
//        Console.WriteLine("удовлетворительно"); break;
//    case 4:
//        Console.WriteLine("хорошо"); break;
//    case 5:
//        Console.WriteLine("отлично"); break;
//}

//задание 7
//int.TryParse(Console.ReadLine(), out int chislo);
//double S = 0;
//switch (chislo)
//{
//    case 1:
//        int.TryParse(Console.ReadLine(), out int radius);
//        S = Math.PI * Math.Pow(radius, 2); break;
//    case 2:
//        int.TryParse(Console.ReadLine(), out int diametr);
//        S = Math.Pow(diametr, 2) /4 * Math.PI; break;
//    case 3:
//        int.TryParse(Console.ReadLine(), out int dlina);
//        S = Math.Pow(dlina, 2) / (4 * Math.PI); break;
//}
//Console.WriteLine(S);

//задание 8

//int.TryParse(Console.ReadLine(), out int chislo);

//switch (chislo)
//{
//    case 1:
//        int.TryParse(Console.ReadLine(), out int katet);
//        double gipotenyza1 = Math.Sqrt(2 * Math.Pow(katet, 2));
//        Console.WriteLine("гипотенуза: " + gipotenyza1);
//        double visota1 = gipotenyza1 / 2;
//        Console.WriteLine("высота: " + visota1);
//        double S1 = 0.5 * gipotenyza1 * katet;
//        Console.WriteLine("площадь: " + S1);
//        break;
//    case 2:
//        int.TryParse(Console.ReadLine(), out int gipotenyza);
//        double katet1 = Math.Sqrt(Math.Pow(gipotenyza, 2)) / 2;
//        Console.WriteLine("катет: " + katet1);
//        double visota2 = gipotenyza /2;
//        Console.WriteLine("высота: " + visota2);
//        double S2 = 0.5 * gipotenyza * visota2;
//        Console.WriteLine("площадь: " + S2);
//        break;
//    case 3:
//        int.TryParse(Console.ReadLine(), out int visota);
//        double gipotenuza2 = Math.Sqrt(2 * Math.Pow(visota, 2));
//        Console.WriteLine("гипотенуза: " + gipotenuza2);
//        double katet2 = visota;
//        Console.WriteLine("катет: " + katet2);
//        double S3 = 0.5 * gipotenuza2 * visota;
//        Console.WriteLine("площадь: " + S3);
//        break;

//    case 4:
//        int.TryParse(Console.ReadLine(), out int plochad);
//        double katet3 = plochad / 1.5;
//        Console.WriteLine("катет: " + katet3);
//        double gipotenyza3 = Math.Sqrt(2 * Math.Pow(katet3, 2));
//        Console.WriteLine("гипотенуза: " + gipotenyza3);
//        double visota3 = katet3;
//        Console.WriteLine("высота: " + visota3);
//        break;
//}

//задание 9
//int.TryParse(Console.ReadLine(), out int nomer);

//switch(nomer)
//{
//    case 1:
//        Console.WriteLine("февраль"); break;
//    case 2:
//        Console.WriteLine("март"); break;
//    case 3:
//        Console.WriteLine("апрель"); break;
//    case 4:
//        Console.WriteLine("май"); break;
//    case 5:
//        Console.WriteLine("июнь"); break;
//    case 6:
//        Console.WriteLine("июль"); break;
//    case 7:
//        Console.WriteLine("август"); break;
//    case 8:
//        Console.WriteLine("сентябрь"); break;
//    case 9:
//        Console.WriteLine("октябрь"); break;
//    case 10:
//        Console.WriteLine("ноябрь"); break;
//    case 11:
//        Console.WriteLine("декабрь"); break;
//    case 12:
//        Console.WriteLine("январь"); break;
//}

//задание 10
//int.TryParse(Console.ReadLine(), out int nomer);

//switch (nomer)
//{
//    case 1:

//        Console.WriteLine("январь: 31"); 
//        Console.WriteLine("февраль: 28");
//        Console.WriteLine("декабрь: 31");
//        break;
//    case 2:
//        Console.WriteLine("март: 31"); 
//        Console.WriteLine("апрель: 30"); 
//        Console.WriteLine("май: 31"); 
//        break;
//    case 3:
//        Console.WriteLine("июнь: 30"); 
//        Console.WriteLine("июль: 31"); 
//        Console.WriteLine("август: 31"); 
//        break;
//    case 4:
//        Console.WriteLine("сентябрь: 30");
//        Console.WriteLine("октябрь: 31"); 
//        Console.WriteLine("ноябрь: 30"); 
//        break;
//}

//Залевская Полина и Никитина Алёна

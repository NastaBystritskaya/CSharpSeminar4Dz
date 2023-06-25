// Напишите цикл, который принимает на вход 2 числа (А, В) и возводит число А в натуральную степень В.

int get_number (string text) {
    System.Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

double get_pow(int number, int pow) {
    double result = Math.Pow(number, pow);
    return result; 
}


void Main () {
    int input1 = get_number("Введите число возводимое в степень: ");
    int input2 = get_number("Введите степень числа: ");
    double result = get_pow (input1, input2);
    System.Console.WriteLine(result);
}

Main();
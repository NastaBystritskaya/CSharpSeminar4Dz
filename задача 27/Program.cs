// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
void Main () {
    string input = get_user_input();
    int result = get_sum(input);
    System.Console.WriteLine(result);
}

string? get_user_input () {
    System.Console.WriteLine("Введите число: ");
    string? input = System.Console.ReadLine();
    return input;
}

int get_sum (string input) {
    int sum = 0;
    for(int i = 0; i < input.Length; i++) {
        sum = sum + int.Parse(input[i].ToString());
    }
    return sum;
}
Main();
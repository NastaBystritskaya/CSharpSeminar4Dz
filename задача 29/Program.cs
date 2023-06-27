// Напишите программу, которая задает массив из 8 элементов и выводит их на экран

int[] massiv = new int[8];
for (int i = 0; i<8; i++) {
    massiv[i] = new Random().Next(0, 100);
}
System.Console.WriteLine(string.Join(", ", massiv));
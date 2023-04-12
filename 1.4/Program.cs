//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
int i = 1;
bool not = true;

Console.WriteLine("Введите число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа 1 до " + num_1);
while (i <= num_1){
    if (i % 2 != 1){
        Console.Write(i + " , ");
        not = false;
    }
    i++;
}
if (not){
    Console.WriteLine("Нет Чётных чисел");
}
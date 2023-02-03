//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArr = GetArray(length);
int result = CountNum(myArr);
System.Console.WriteLine("Результат " + result);

int[] GetArray(int len)
{
    int[] newArr = new int[len];
    for(int i=0; i<len;i++)
    {
        System.Console.WriteLine($"Введите значение {i} элемента массива");
        newArr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArr;
}

int CountNum(int[] arr)
{
    int res = 0;
    for(int i=0; i<arr.Length;i++)
    {
        if (arr[i]>0)
        {
            res++;
        }
    }
    return res;
}
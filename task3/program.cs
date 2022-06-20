//Напишите программу, которая задаёт массив из 8 элементов случайными 
//числами и выводит их на экран. Оформите заполнение массива и вывод в 
//виде функции (пригодится в следующих задачах)


void Fillarray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,2000);
        index++;
    }

}

void Printarray(int[] col)
{
 int count = col.Length;
 int position = 0;
 while (position < count)
 {
    System.Console.WriteLine(col[position]);
    position++;
 }

}
int[] array = new int[8];
Fillarray(array);
Printarray(array);
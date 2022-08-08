int[] array = {3,12,51,1,5,5,4,12,4,5};

int n = array.Length;
int find = 5;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
int[] array = { 19, 26, 83, 48, 15, 62, 37, 48, 15 };

int n = array.Length;
int find = 15;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }

    index++;
}





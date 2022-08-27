int[] array = {12, 24, 37, 43, 56, 61, 74, 89, 61};

int n = array.Length;
int find = 61;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}
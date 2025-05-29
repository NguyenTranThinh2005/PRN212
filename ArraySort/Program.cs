void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
//C1
void sortArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i+1; j < arr.Length; j++)
        {
            if(arr[i] > arr[j])
            {
                swap(ref arr[i],ref arr[j]);               
            }
        }
    }
}
void createArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(50);
    }
}
void exportArray(int[] arr)
{
    foreach (int i in arr)
    {
        Console.WriteLine($"{i}\t");
    }
}

//C2
void sortArrayDox2(int[] arr)
{
   
    bool swapped =false;
    do
    {
        swapped = false;
        int n = 0;
        do
        {
            if (arr[n] > arr[n + 1])
            {
                swap(ref arr[n], ref arr[n + 1]);
                swapped = true;
            }
            n++;
            
        } while (n < arr.Length - 1);
    }while (swapped);
}
//
int[] arr = new int[10];
createArray(arr);
Console.WriteLine("mang trc khi sap xep:");
exportArray(arr);
Console.WriteLine("mang sau khi sap xep: ");
sortArrayDox2(arr);
exportArray(arr);

//2 vong do while long nhau, 2 vong while long nhau


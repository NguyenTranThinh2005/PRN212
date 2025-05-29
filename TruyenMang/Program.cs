(int,double) sumAndAvg (params int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        sum += arr[i];
    double avg =sum/arr.Length;
    return (sum, avg);
}
int[] arr = { 1, 6, 3, 6 };
(int s,double v)=sumAndAvg(arr);
Console.WriteLine($"Sum={s}; Avg={v}");
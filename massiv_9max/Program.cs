int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
int[] Massiv = { 12, 44, 23, 33, 99, 20, 64, 11, 19 };

int max = Max (
    Max (Massiv[0], Massiv[1], Massiv[2]),
    Max (Massiv[3], Massiv[4], Massiv[5]),
    Max (Massiv[6], Massiv[7], Massiv[8])
);

Console.WriteLine(max);
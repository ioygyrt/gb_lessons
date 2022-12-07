int Max (int arg1, int arg2, int arg3)
{
    int result = arg1; 
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int xa = 11;
int xb = 12;
int xc = 66;
int xd = 2999;
int xe = 44;
int xf = 33;
int xg = 13;
int xh = 75;
int xi = 90;

int max1 = Max(xa,xb,xc);
int max2 = Max(xd,xe,xf);
int max3 = Max(xg,xh,xi);
int max = Max(max1, max2, max3);

Console.WriteLine (max);    

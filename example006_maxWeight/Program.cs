int a = 1;
int b = 12;
int c = 16;
int d = 18;
int e = 4;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

System.Console.WriteLine("Максимальное значение: " + max);
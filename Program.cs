int a1 = 34;
int b1 = 65;
int c1 = 346573;
int a2 = 12676;
int b2 = 133;
int c2 = 1887;
int a3 = 17671;
int b3 = 1263;
int c3 = 237;

int min = a1;
if (b1 < min) min = b1;
if (c1 < min) min = c1;

if (a2 < min) min = a2;
if (b2 < min) min = b2;
if (c2 < min) min = c2;

if (a3 < min) min = a3;
if (b3 < min) min = b3;
if (c3 < min) min = c3;

Console.Write("Мінімальне число ");
Console.WriteLine(min);

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max= c3;

Console.Write("Максимальне число "); 
Console.Write(max);
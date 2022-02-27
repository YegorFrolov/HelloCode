Console.Clear();
/*
Console.SetCursorePosition(10, 4);
Console.Write("х");
*/

int xa = 30 , ya = 1,
    xb = 1 , yb = 30,
    xc = 60 , yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("o");
Console.SetCursorPosition(xb, yb);
Console.WriteLine ("o");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("o");


int x = xa, y = xb;
int count = 0;
while (count < 1000)
{
    int what = new Random().Next(0, 3); // [0,3) 0,1,2,  3 
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }     
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }         
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }   
    Console.SetCursorPosition(x, y);
    Console.WriteLine("x");
    count++;
}

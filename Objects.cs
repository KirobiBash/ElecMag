//This is for incrementation
int x = 10;
x++;
Console.WriteLine(x);
/*This should output 11 because x++;
is equivalent to x = x + 1*/

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

++x; //prefix
x++; //postfix

/*The prefix increments the value before proceeding with the expression
as the postfix does it afterwards.*/

int x = 3;
int y = ++x;
// x is 4, y is 4


int x = 3;
int y = x++;
// x is 3, y is 4

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

--x; // Same as the increment, it is called decrement
x--; //decrement before the variable

//This applies to the same thing.

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


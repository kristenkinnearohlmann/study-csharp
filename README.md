# Study C#

## Prefix and Postfix
- Prefix increments the value, and then proceeds with the expression.  
```C#
// ++x; //prefix
int x = 3;
int y = ++x;
// x is 4, y is 4
// The prefix example increments the value of x, and then assigns it to y.
```

- Postfix evaluates the expression and then performs the incrementing.
```C#
// x++; //postfix
int x = 3;
int y = x++;
// x is 4, y is 3
//The postfix example assigns the value of x to y, and then increments x.
```
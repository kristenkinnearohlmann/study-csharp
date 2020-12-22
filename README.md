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

## Alternate Expressions
They’re called expression-bodied definitions and lambda expressions.

From now on, when you see these phrases just think: “These are shortcuts for defining methods!” This lesson will show you how to use them.

expression-bodied definitions
- `bool isEven(int num) => num % 2 == 0;`
- can only contain 1 expression

lambad expressions
- `bool hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0 );`
- define a method in the call to the calling method
- this is an anonymous method
- if defining only one expression, can be defined as `(input-parameters) => expression`
- if defining as multiple expressions, defined as `(input-parameters) => { statement; }`
- if the parm types are obviously typed, remove type declaration `bool hasEvenNumbers = Array.Exists(numbers, (num) => num % 2 == 0 );`
- if there is a single, obiously typed parameter, can condense to `bool hasEvenNumbers = Array.Exists(numbers, num => num % 2 == 0 );`
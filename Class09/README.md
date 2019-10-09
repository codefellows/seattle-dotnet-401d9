# Class 09: Recursion

## Learning Objectives
1. Students will know how to implement recursion.
2. Students will know and understand the bounds and limitations of recursion.

## Lecture Outline

### Recursion
1. What is Recursion?
	- Recursion occurs when a method calls itself. 
		- direct: the method calls itself
		- indirect: method calls some other method that then calls the first method)
1. Recursion is not a 'fix all' solution:
	- it can suffer performance of an applicaiton because of using call stack again and again is not always a good choice. 


1. The Factorial of N is written N! (pronounced "N Factorial")
```csharp
0! = 1
1! = 1
2! = 2 * 1! = 2
3! = 3 * 2! = 3 * 2* 2 * 0! = 3 * 2* 1* 1
```
Code for a non recursive approach:

```csharp

public long Factorial(int n)
{
    if (n == 0)
        return 1;
    long value = 1;
    for (int i = n; i > 0; i--)
    {
        value *= i;
    }
    return value;
}
```

Recursive approach:

```csharp
Long Factorial (Integer: n)

If(n==0) Then Return 1
Return n * Factorial(n-1)
End Factorial

public long Factorial(int n)
{
    if (n == 0) 
        return 1;
    return n * Factorial(n - 1);
}
```
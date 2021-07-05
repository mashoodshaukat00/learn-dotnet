# learn-dotnet

Useful Links :

- https://codeasy.net/course/csharp_beginner
- 

## **Basic Exercises :** 

1. Write a method that checks if given number (positive integer) contains digit 3. Do not convert number to other type. Do not use built-in functions like `Contains(), StartsWith()`, etc.

   Expected input and output

   ```csharp
   IfNumberContains3(7201432) → true
   IfNumberContains3(87501) → false
   ```

2. Given a year as integer, write a method that checks if year is leap.

   Expected input and output

```csharp
   IfYearIsLeap(2016) → true
   IfYearIsLeap(2018) → false
```

3. Given three numbers, write a method that adds two first ones and multiplies them by a third one.

    Expected input and output

```csharp
 AddAndMultiply(2, 4, 5) → 30
```

4. Given a string, write a method that checks if it is a palindrome (is read the same backward as forward). Assume that string may consist only of lower-case letters.

   Expected input and output

   ```csharp
   IsPalindrome("eye") → true 
   IsPalindrome("home") → false
   ```

5. Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees. Remember that temperature below -271.15°C (absolute zero) does not exist!

   Expected input and output

  ```csharp
   CtoF(0) → "T = 32F" CtoF(100) → "T = 212F" CtoF(-300) → "Temperature below absolute zero!
  ```

6. Given two integers, write a method that returns results of their elementary arithmetic operations: addition, substraction, multiplication, division. Remember that you can't divide any number by 0!

   Expected input and output
   
   ```csharp
   ElementaryOperations(3, 8) → 11, -5, 24, 0.375
   ```

7. Given two different arithmetic operations (addition, substraction, multiplication, division), write a method that checks if they return the same result.

   Expected input and output
   
   ```csharp
   sResultTheSame(2+2, 2*2) → true IsResultTheSame(9/3, 16-1) → false
   ```
   
8. Given three integers, write a method that returns first number divided modulo by second one and these divided modulo by third one.

   Expected input and output
   
   ```csharp
   ModuloOperations(8, 5, 2) → 1
   ```
   
9. Given a number, write a method that returns its cube.

   Expected input and output
   
   ```csharp
   TheCubeOf(2) → 8
   TheCubeOf(-5.5) → -166.375
   ```
   
10.  Given two integers, write a method that swaps them using temporary variable.

    Expected input and output

    ```csharp
    SwapTwoNumbers(87, 45) → "Before: a = 87, b = 45; After: a = 45, b = 87" 
    SwapTwoNumbers(-13, 2) → "Before: a = -13, b = 2; After: a = 2, b = -13
    ```
    

##    Conditional Statements :

1. Given an integer, write a method that returns its absolute value.

   Expected input and output

   ```csharp
   AbsoluteValue(6832) → 6832 AbsoluteValue(-392) → 392
   ```

2. Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns thier sum.

   Expected input and output

   ```csharp
   DivisibleBy2Or3(15, 30) → 450
   DivisibleBy2Or3(2, 90) → 180
   DivisibleBy2Or3(7, 12) → 19
   ```

3. Given a 3 characters long string, write a method that checks if it consists only of uppercase letters.

   Expected input and output

   ```csharp
   IfConsistsOfUppercaseLetters("xyz") → false IfConsistsOfUppercaseLetters("DOG") → true IfConsistsOfUppercaseLetters("L9#") → false
   ```

4. Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers is greater than third one.

   Expected input and output

   ```csharp
   IfGreaterThanThirdOne([2, 7, 12]) → true IfGreaterThanThirdOne([-5, -8, 50]) → false
   ```

5. Given an integer, write a method that checks if it is even.

   Expected input and output

   ```csharp
   IfNumberIsEven(721) → false IfNumberIsEven(1248) → true
   ```

6. Given an array of three integers, write a method that checks if they are sorted in ascending order.

   Expected input and output

   ```csharp
   IfSortedAscending([3, 7, 10])→ true IfSortedAscending([74, 62, 99])→ false
   ```

7. Given three letter long string, write a method that checks if at least one neighbour of middle letter is its neighbour in the alphabet.

   Expected input and output

   ```csharp
   IsLonelyIsland("XYZ") → True IsLonelyIsland("GWK") → False
   ```

8. Given a number, write a method that checks if it is positive, negative or zero.

   Expected input and output

   ```csharp
   PositiveNegativeOrZero(5.24) → positive PositiveNegativeOrZero(0.0) → zero PositiveNegativeOrZero(-994.53) → negative
   ```

   

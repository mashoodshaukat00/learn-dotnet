# learn-dotnet

Useful Links :

- [ ] https://codeasy.net/course/csharp_beginner

  


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

## Loops :

1. #### Multiplication table

   Write a method that prints 10 by 10 multiplication table. Remember about readibility (spaces in the right place).

   Expected input :

   ```csharp
   MultiplicationTable();
   ```

   Expected output

   ```csharp
   1  2  3  4  5  6  7  8  9 10
   2  4  6  8 10 12 14 16 18 20
   3  6  9 12 15 18 21 24 27 30
   4  8 12 16 20 24 28 32 36 40
   5 10 15 20 25 30 35 40 45 50
   6 12 18 24 30 36 42 48 54 60
   7 14 21 28 35 42 49 56 63 70
   8 16 24 32 40 48 56 64 72 80
   9 18 27 36 45 54 63 72 81 90
   10 20 30 40 50 60 70 80 90 100
   ```

2. #### Fractions sum

   Given an integer n, write a method that returns sum of series 1 + (½)² + (⅓)² + ... + (1⁄n)². Do not use library function!

   Expected input and output

   ```csharp
   FractionsSum(3) → 1.36111111111111 FractionsSum(5) → 1.46361111111111
   ```

3. #### Sort array ascending

   Given an array of integers, write a method that returns sorted array in ascending order.

   Note : Use loops and do not use built-in functionality if available)

   Expected input and output

   ```csharp
    SortArrayAscending([9, 5, 7, 2, 1, 8]) →  [1, 2, 5, 7, 8, 9]
   ```

4. #### The biggest number

   Given an array of integers, write a method that returns the biggest number in this array.

   Expected input and output

   ```csharp
   TheBiggestNumber([190, 291, 145, 209, 280, 300]) → 291 
   
   TheBiggestNumber([-9, -2, -7, -8, -4]) → -2
   ```

5. #### Two 7s next to each other

   Given an array of positive digits, write a method that returns number of times that two 7's are next to each other in an array.

   Expected input and output

   ```
   Two7sNextToEachOther([ 8, 2, 5, 7, 9, 0, 7, 7, 3, 1]) → 1 
   
   Two7sNextToEachOther([ 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 ]) → 3
   ```

6. #### Three increasing adjacent

   Given an array of numbers, write a method that checks if there are three adjacent numbers where second is greater by 1 than the first one and third is greater by 1 than the second one.

   Expected input and output

   ```
   ThreeIncreasingAdjacent([45, 23, 44, 68, 65, 70, 80, 81, 82 ]) → True 
   
   ThreeIncreasingAdjacent([7, 3, 5, 8, 9, 3, 1, 4 ]) → False
   ```

7. #### Return even Numbers

   Write a method that returns a string of even numbers greater than 0 and less than 100.

   Expected input and output

   ```csharp
   ReturnEvenNumbers() → "2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98"
   ```

8. #### Sieve of Eratosthenes

   Given an integer n (n>2), write a method that returns prime numbers from range [2, n].

   Expected input and output

   ```csharp
   SieveOfEratosthenes(30) → [2, 3, 5, 7, 11, 13, 17, 19, 23, 29]
   ```

9. #### Draw hourglass 

   Write a method that takes a string character as parameter and draws hourglass shape using that character, as like below. 

   Expected input :

   ```csharp
   DrawHourglass("*") ;
   ```

   Expected output : 

   ```csharp
   ***********
    *********
     *******
      *****
       ***
        *
       ***
      *****
     *******
    *********
   ***********
   ```

   

10. #### Draw parallelogram

    Write a method that draws parallelogram shape with provided parameter character, as  like below.

    Expected input and output

```csharp
DrawParallelogram("*");
```

Expected output : 

```csharp
     ***************
    ***************
   ***************
  ***************
 ***************
```

11. #### Draw Christmas tree

    Write a method that draws Christmas tree shape like below.

    Expected input and output

    ```csharp
    DrawChristmasTree("*");
    ```
    Expected output :     

    ```csharp
       *
      ***
     *****
    *******
       *
      ***
     *****
    *******
       *
      ***
     *****
    *******
    ```

12. #### Extract String

    Given a string, write a method that returns substring from between two double hash signs (#).

    Expected input and output

    ```csharp
    ExtractString("##abc##def"); //→ "abc"
    ExtractString("12####78"); // → empty string
    ExtractString("gar##d#en"); // → empty string
    ExtractString("++##--##++"); //  → "--"
    ```

13. #### Full sequence of letters

    Given a string of two letters, where first one occurs before the second in the alphabet, write a method that returns full sequence of letters starting from first and ending at the second one.

    Expected input and output

    ```csharp
    FullSequenceOfLetters("ds") → "defghijklmnopqrs" 
    
    FullSequenceOfLetters("or") → "opqr"
    ```

14. #### Bits to Number 

    Write a method that takes non-empty string of bits as an argument and returns number as integer.

    Expected input and output

    ```csharp
    BitsToNumber("1") → 1
    
    BitsToNumber("100010") → 34
    ```

15. #### Digits sum

    Given a non-negative number, write a method that returns sum of its digits.

    Expected input and output

    ```csharp
    DigitsSum(5434) → 16 
    DigitsSum(904861) → 28
    ```
    
16. #### Sum and average

    Given two integers n and m (n <= m), write a method that returns sum of all integers and average from range [n, m].

    Expected input and output

    ```csharp
    SumAndAverage(11, 66) → "Sum: 2156, Average: 38.5" 
    
    SumAndAverage(-10, 0) → "Sum: -55, Average: -5"
    ```

17. #### Sum double only

    Given an array of objects, write a method that returns sum of objects of double type.

    Expected input and output

    ```csharp
    SumDoubleOnly(["abc", 5.6, 14, 'c', true, 'x', false, 567, 2.22]) → 7.82
    ```

18. #### Draw triangle

    Write a method that draws triangle shape like below.

    Expected input:

     ```csharp
     DrawTriangle("*"); 
     ```

    Expected output:

    ```csharp
             *
            **
           ***
          ****
         *****
        ******
       *******
      ********
     *********
    **********
    ```

19. #### To the power of

    Given two integers, write a method that returns first number raised to the power of second one.

    Expected input and output

    ```csharp
    ToThePowerOf(-2, 3) → -8
    
    ToThePowerOf(5, 5) → 3125
    ```

20. #### Letters balance

    Given a string, write a method that checks if there are exactly the same letters on the left side and right side of the string. Assume string length is even and letters don't repeat on each side.

    Expected input and output

    ```csharp
    LettersBalance("fgvgvf") → true
    
    LettersBalance("lampsmpser") → false
    ```

    

21. #### Replace two words

    Given a string in which two words are separated by a char, write a method that replaces these two words.

    Expected input and output

    ```csharp
    ReplaceWords("abc_xyz", '_') → xyz_abc 
    
    ReplaceWords("trolling.master", '.') → master.trolling
    ```

22. #### Digital root

    Given a non-negative number, write a method that returns its digital root. From Wikipedia - digital root is a value obtained by an iterative process of summing digits, on each iteration using the result from the previous iteration to compute a digit sum. The process continues until a single-digit number is reached.

    Expected input and output

    ```csharp
    DigitalRoot(83) → 2 
    
    DigitalRoot(40002938) → 8
    ```

23. #### Longest strictly increasing sequence

    Given an array of integers, write a method that returns value of the longest strictly increasing sequence of numbers.

    Expected input and output

    ```csharp
    LongestStrictlyIncreasingSequence([0, 3, 4, 5, 6, 4, 9]) → 3 
    
    LongestStrictlyIncreasingSequence([7, 7, 7, 7, 7]) → 0
    ```

    

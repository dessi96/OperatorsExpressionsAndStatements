Homework: Operators Expressions and Statements

This document defines homework assignments from the “C# Basics“ Course @ Software University. Please submit as homework a single zip / rar / 7z archive holding the solutions (source code only) of all below described problems.

Problem 1.	Odd or Even Integers

Write an expression that checks if given integer is odd or even.


Problem 2.	Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth. 
weight	weight on the Moon


Problem 3.	Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 


Problem 4.	Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height. 


Problem 5.	Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7. 


Problem 6.	Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:

•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).

•	Prints on the console the number in reversed order: dcba (in our example 1102).

•	Puts the last digit in the first position: dabc (in our example 1201).

•	Exchanges the second and the third digits: acbd (in our example 2101).

The number has always exactly 4 digits and cannot start with 0. 


Problem 7.	Point in a Circle

Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 


Problem 8.	Prime Number Check

Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). 
n	Prime?


Problem 9.	Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h. 


Problem 10.	Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 


Problem 11.	Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. 


Problem 12.	Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p. 


Problem 13.	Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. 


Problem 14.	Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. 


Problem 17.	Volleyball


Vladi loves a lot to play volleyball. However, he is a programmer now and he is very busy. Now he is able to play only in the holidays and in the weekends. Vladi plays in 2/3 of the holidays and each Saturday, but not every weekend – only when he is not at work and only when he is not going to his hometown. Vladi goes at his hometown h weekends in the year. The other weekends are considered “normal”. Vladi is not at work in 3/4 of the normal weekends. When Vladi is at his hometown, he always plays volleyball with his old friends once, at Sunday. In addition, if the year is leap, Vladi plays volleyball 15% more times additionally. We assume the year has exactly 48 weekends suitable for volleyball.
Your task is to write a program that calculates how many times Vladi plays volleyball (rounded down to the nearest integer number).

Input

The input data should be read from the console. It consists of three input values, each at separate line:

•	The string “leap” for leap year or “normal” for year that is not leap.

•	The number p – number of holidays in the year (which are not Saturday or Sunday).

•	The number h – number of weekends that Vladi spends in his hometown.

The input data will always be valid and in the format described. There is no need to check it explicitly.

Output

•	The output data must be printed on the console.

•	On the only output line you must print an integer representing how many times Vladi plays volleyball for a year.

Constraints

•	The numbers p is in range [0...300] and h is in range [0…48].

•	Allowed working time for your program: 0.25 seconds.

•	Allowed memory: 16 MB.


using System;
using OperatorExercise;

//Exercise 1

int quotient = Operator.Divide(17, 4);
int modulo = Operator.Modulo(17, 4);


Console.WriteLine($"17/4 is {quotient} remainder {modulo}");



//Exercise 2

Console.WriteLine("What is the radius of your circle?");
var radius = double.Parse(Console.ReadLine());

Console.WriteLine($"The area of a circle with radius of 20 is {Operator.AreaOfCircle(radius)}."); 








﻿using System;
/*
 Write a program to Create a QuadraticEquation class as per the below specification
The equation form is:
-------------------------------------------------------
|QuadraticEquation                                    |
-------------------------------------------------------
| - a, b, c : double                                  |
| - real_val: double                                  |
| - img_val : double                                  |
-------------------------------------------------------
| + QuadraticEquation()                               |
| + QuadraticEquation (double a, double b, double c)  |
| + solveEquation() :void                             |
| + DisplayEquation(): void                           |
| + DisplayResult() :void                             |
-------------------------------------------------------
                   
    1.	Contructor accepts the three coefficients according to the quadratic equation form
    2.	Default Constructor: Initializes the coefficients to using user inputs.
    3.	Solve(): Solves the quadratic equation for given coefficients using the formula. 
    4.	DisplayEquation(): Displays the equation
    5.	DisplayResult(): Displays the results

    In the Main() method:
    1. Create an Object of the QuadraticEquation class
    2. Call the QuadraticEquation (double a, double b, double c) constructor for initializing the coefficients.
    3. Call solveEquation() to solve the equation
    4. Call DisplayEquation() and the DisplayResult()

    **** Before solving the question please check the instructions given in the tutorial question sheet ****
 */


namespace Week5LabProgram
{
    // Create the class
    class QuadraticEquation
    {
        // /*Complete the code Declare the data variables
        private double ;
        private double ;

        // Complete the code for Default Constructor
        public QuadraticEquation()
        {
            Console.Write("\nEnter the Coefficient Values for Cofficient a:");
            a = /*Complete the code*/;
            Console.Write("\nEnter the Coefficient Values for Cofficient b:");
            b = /*Complete the code*/;
            Console.Write("\nEnter the Coefficient Values for Cofficient c:");
            c = /*Complete the code*/;
        }
        // Complete the code for Overloaded Constrcutor
        public QuadraticEquation(double a, double b, double c)
        {
            .a = a;
            .b = b;
            .c = c;
        }
        // /*Complete the code Method to solve the equation
        public void SolveEquation()
        {
            // Calculate the b^2 - 4ac part
            double sqrtpart = /*Complete the code*/;

            // Check if b^2 -4ac >0
            if (sqrtpart > 0)
            {
                real_val = /*Complete the code*/;
                img_val = /*Complete the code*/;
            }
            // Check if b^2 -4ac <0
            if (sqrtpart < 0)
            {
                real_val = /*Complete the code*/;
                img_val = /*Complete the code*/;
            }
            // Check if b^2 -4ac ==0
            if (sqrtpart == 0)
            {
                real_val = /*Complete the code*/);
            }
        }
        // Display the equation in ax^2 + bx +c = 0 form
        public void DisplayEquation()
        {
            /*Complete the code*/
            Console.WriteLine("\nThe Equation is: \n ", a, b, c);
        }

        // Display the result based on the value of b^2 -4ac
        public void DisplayResult()
        {
            if (img_val == 0)
                Console.WriteLine("The Result is: x= {0}", /*Complete the code*/);
            else
                Console.WriteLine("The Result is: x= {0}, {1}",/*Complete the code*/);
        }
    }

    // Class for the main()
    class QuadraticEquationTest
    {
        static void Main(string[] args)
        {
            // Create an equation from user input
           QuadraticEquation eq1 = /*Complete the code*/;
            // Solve the equation
            eq1./*Complete the code*/;
            // Display the equation
            eq1./*Complete the code*/;
            // Display the result
            eq1./*Complete the code*/;

            // Accept key press from user.
            Console.ReadKey();
        }
    }
}

/*
 Test Case: 

Enter the Coeffient Values for Cofficient a: 2

Enter the Coeffient Values for Cofficient b: 2

Enter the Coeffient Values for Cofficient c: 1

The Equation is:
 2x^2 + 2x + 1 = 0

The Result is: x= -0.5, 0.5
 */

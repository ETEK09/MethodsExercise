using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise;

public class Methods

{
    public static int Add(int num1, int num2)
    {
        int sum = num1 + num2;

        return sum;
    }

    public static int Subtract(int num1, int num2)
    {
        int sum = num1 - num2;
        return sum;

    }

    public static int muliply(int num1, int num2)
    {
        int sum = num1 * num2;
        return sum;

    }

    public static int divide(int num1, int num2)
    {
        int sum = num1 / num2;
        return sum;

    }
}

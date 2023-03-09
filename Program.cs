namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        // Assignment Operators
        // =, +=, -=, *=, /=, %=

        int x = 10; // x = 10        
        x += 5;     // x = 15
        x -= 5;     // x = 10
        x *= 5;     // x = 50
        x /= 5;     // x = 10
        x %= 3;     // x = 1

        //---------------------
        // Comparison Operators
        // ==, <, >, <=, >=, !=

        int a = 11;
        int b = 10;
        bool result;
        result = a == b;    // false
        result = a != b;    // true
        result = a < b;     // false
        result = a > b;     // true
        result = a <= b;    // false
        result = a >= b;    // true

        //--------------------------
        // Boolean Logical Operators
        // !, &&, ||

        int y = 10;
        int z = 8;
        bool logic;
        logic = z > y && z < y;     // false AND true = false
        logic = z < y && y > z;     // true AND true = true
        logic = z > y || z < y;     // false OR true = true
        logic = !(z < y);           // !(true) = false

        //---------------------
        // Arithmetic Operators
        // +, -, *, /, %, ++, --

        int c = 12;
        int d = 4;
        int res;
        res = c + d; // 15
        res = c - d; // 8
        res = c * d; // 48
        res = c / d; // 3
        c++;
        res = c;     // 13
        d--;
        res = d;     // 3
        res = 8 % 3; // 2 

    }
}

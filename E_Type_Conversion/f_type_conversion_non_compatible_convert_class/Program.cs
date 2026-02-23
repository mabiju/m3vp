// type conversion of non compatible data types using convert class
namespace f_type_conversion_non_compatible_convert_class;

class Program
{
    static void Main(string[] args)
    {
        string a = "123";
        int b = Convert.ToInt32(a);
        int c = 456;
        int sum = b + c;
        Console.WriteLine("String a = " + a); // prints string value
        Console.WriteLine("Converted Integer b = " + b); // prints integer value
        Console.WriteLine("Sum = " + sum);
    }
}
/* 
Convert classes
ToByte() -> byte
ToInt16() -> short
ToInt32() -> int
ToInt64() -> long
 */
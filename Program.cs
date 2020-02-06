using System;

namespace EnumFlagsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Enum1 enum1 = Enum1.MyValue | Enum1.OtherValue;
            Enum1Flags enum1Flags = Enum1Flags.MyValue | Enum1Flags.OtherValue;

            //Enum1: 3
            Console.WriteLine($"Enum1      : {enum1}");
            //Enum1Flags: MyValue, OtherValue
            Console.WriteLine($"Enum1Flags : {enum1Flags}");

            Console.ReadKey();
        }

        enum Enum1 : long { MyValue = 1, OtherValue = 2 }

        [Flags]
        enum Enum1Flags : long { MyValue = 1, OtherValue = 2 }
    }
}

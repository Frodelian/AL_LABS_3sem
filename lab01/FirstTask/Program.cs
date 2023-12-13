﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Boolean:    Min value = {0}    Max value = {1}", System.Boolean.FalseString, System.Boolean.TrueString);

            Console.WriteLine("Type Char:       Min value = {0}    Max value = {1}", System.Char.MinValue, System.Char.MaxValue);

            Console.WriteLine("Type Decimal:    Min value = {0}    Max value = {1}", System.Decimal.MinValue, System.Decimal.MaxValue);

            Console.WriteLine("Type DateTime:   Min value = {0}    Max value = {1}", System.DateTime.MinValue, System.DateTime.MaxValue);

            Console.WriteLine("Type Double:     Min value = {0}    Max value = {1}", System.Double.MinValue, System.Double.MaxValue);

            Console.WriteLine("Type Single:     Min value = {0}    Max value = {1}", System.Single.MinValue, System.Single.MaxValue);

            Console.WriteLine("Type SByte:      Min value = {0}    Max value = {1}", System.SByte.MinValue, System.SByte.MaxValue);

            Console.WriteLine("Type Byte:       Min value = {0}    Max value = {1}", System.Byte.MinValue, System.Byte.MaxValue);

            Console.WriteLine("Type Int16:      Min value = {0}    Max value = {1}", System.Int16.MinValue, System.Int16.MaxValue);

            Console.WriteLine("Type Int32:      Min value = {0}    Max value = {1}", System.Int32.MinValue, System.Int32.MaxValue);

            Console.WriteLine("Type Int64:      Min value = {0}    Max value = {1}", System.Int64.MinValue, System.Int64.MaxValue);

            Console.WriteLine("Type UInt16:     Min value = {0}    Max value = {1}", System.UInt16.MinValue, System.UInt16.MaxValue);

            Console.WriteLine("Type UInt32:     Min value = {0}    Max value = {1}", System.UInt32.MinValue, System.UInt32.MaxValue);

            Console.WriteLine("Type UInt64:     Min value = {0}    Max value = {1}", System.UInt64.MinValue, System.UInt64.MaxValue);

        }
    }
}
// Здесь мы видим, что строка в Console.WriteLine содержит некие числа в фигурных скобках: { 0}, { 1}, { 2}. 
// Это плейсхолдеры, вместо которых при выводе строки на консоль будут подставляться некоторые значения.
// Подставляемые значения указываются после строки через запятую.

// Console.WriteLine автоматически делает переход строки в отличие от Console.Write()

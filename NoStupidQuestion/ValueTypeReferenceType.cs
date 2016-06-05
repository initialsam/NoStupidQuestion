using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoStupidQuestion
{
public static class ValueTypeReferenceType
{
    public static void IsValueType()
    {
        byte _byte;
        int _int;
        uint _uint;
        double _double;
        decimal _decimal;
        char _char;
        bool _bool;
        DateTime _dateTime;
        DayOfWeek _enum;
        MyStruct _myStruct;
        Nullable<int> _nullableInt = 1;
        var type = _nullableInt.GetType();
        if (type.IsValueType)
        {
            _nullableInt = 1;
        }
    }

    public static void IsReferenceType()
    {
        string _string;
        IDisposable _IDisposable;
        TimeZone _TimeZone;
        MyClass _myClass;
    }
}

public class MyClass
{
    public int MyInt { get; set; }
    public string MyString { get; set; }
    public override String ToString()
    {
        return string.Format("MyInt=>{0}，MyString=>{1}", MyInt, MyString ?? "null");
    }
}

public struct MyStruct
{
    public int MyInt { get; set; }
    public string MyString { get; set; }
    public override String ToString()
    {
        return string.Format("MyInt=>{0}，MyString=>{1}", MyInt, MyString ?? "null");
    }
}
}

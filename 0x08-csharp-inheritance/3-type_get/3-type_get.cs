using System;
using System.Reflection;

/// <summary> class Obj </summary>
class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo detailList = myObj.GetType().GetTypeInfo();

        Console.WriteLine("{0} Properties:", detailList.Name);

        foreach (PropertyInfo p in detailList.GetProperties())
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("{0} Methods:", detailList.Name);

        foreach (MethodInfo m in detailList.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}

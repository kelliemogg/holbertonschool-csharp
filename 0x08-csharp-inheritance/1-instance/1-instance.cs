using System;

/// <summary> class obj test type and inheritance </summary>
class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        else
            return false;
    }
}

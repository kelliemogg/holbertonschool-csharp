using System;

/// <summary> class Obj test type </summary>
class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return true;
        else
        {
            return false;
        }
    }
}
using System;

/// <summary> class Obj test type </summary>
class Obj
{
    /// <summary> is it an int </summary>
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
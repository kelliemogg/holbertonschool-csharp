using System;

/// <summary> class obj </summary>
class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubClassOf(baseType))
            return true;
        else
            return false;
    }
}

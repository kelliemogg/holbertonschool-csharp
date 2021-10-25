using System;
/// Generic data type
/// of class Queue ///
public class Queue<T>
{
    /// defines generic class and checks the type ///
    public Type CheckType() 
    {
        return typeof(T);
    }
}

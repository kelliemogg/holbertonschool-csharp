using System;

public class Queue<T>
{
    /// defines generic class and checks the type ///
    public Type CheckType() 
    {
        return typeof(T);
    }
}

using System;
/// <summary>
///Generic data type of class Queue
/// </summary>
public class Queue<T>
{
    /// <summary> defines generic class and checks the type </summary> ///
    public Type CheckType() 
    {
        return typeof(T);
    }
}

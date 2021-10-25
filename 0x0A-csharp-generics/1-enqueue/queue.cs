using System;

/// <summary>
///Generic data type of class Queue
/// </summary>

public class Queue<T>
{
    Node head;
    Node tail;
    int count;
    /// <summary>
    /// defines generic class and checks the type 
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    public class Node
    {
        public object value = null;
        public Node next = null;
        public object Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }

    public void Enqueue(T value)
    {
        Node new_n = new Node();

        if (head == null)
        {
            new_n.value = value;
            head = new_n;
            tail = new_n;
            count++;
        }
        else
        {
            new_n.value = value;
            tail.next = new_n;
            tail = new_n;
            count++;
        }
    }
    public int Count()
    {
        return count;
    }
}

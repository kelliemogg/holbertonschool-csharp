using System;

/// <summary>
///Generic data type of class Queue
/// </summary>

public class Queue<T>
{
    /// <summary>
    /// defines generic class and checks the type 
    /// </summary>
    Node head;
    Node tail;
    int count;
    public System.Type CheckType()
    /// <summary>
    /// checks type 
    /// </summary>
    {
        return typeof(T);
    }

    public class Node
    {
        /// <summary>
        /// gets and sets the value of a node 
        /// </summary>
        public object value = null;
        public Node next = null;
        public object Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
    public void Enqueue(T value)
    /// <summary>
    /// adds a new node to the end of a queue 
    /// </summary>
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

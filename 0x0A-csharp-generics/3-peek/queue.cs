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
    /// <summary>
    /// class node defined 
    /// </summary>
    public class Node
    {
        /// <summary>
        /// declaring value
        /// </summary>
        public object value = null;
        /// <summary>
        /// defining next
        /// </summary>
        public Node next = null;
        /// <summary>
        /// obj value 
        /// </summary>
        public object Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
    /// <summary>
    /// enqueue 
    /// </summary>
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
    /// <summary>
    /// removes the node in the queue and returns a value
    /// </summary>
    public object Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return 0;
        }
        else
        {
            Node temp = head;
            head = head.next;
            count--;
            return temp.value;
        }
    }
    /// <summary>
    /// counts number of nodes added 
    /// </summary>
    public int Count()
    {
        return count;
    }
    public object Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        else
        {
            Node temp = head;
            object temp_val = temp.value;
            return temp_val;
        }
    }
}

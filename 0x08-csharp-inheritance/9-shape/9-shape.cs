using System;

///<summary> class Shape </summary>
class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary> Rect inherits from Shape </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    
    public int Width
    {
        get 
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }
    public new int Area()
    {
        int area = 0;
        area = width * height;
        return area;
    }
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}
class Square : Rectangle
{
    private int size;
    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = value;
                Height = value;
                Width = value;
            }
        }
    }
    public override string ToString()
    {
        return string.Format("[Square] {0} / {1}", Width, Height);
    }
}

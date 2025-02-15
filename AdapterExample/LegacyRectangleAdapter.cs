namespace AdapterExample;

public class LegacyRectangleAdapter(LegacyRectangle rectangle) : IRectangle
{
    public long GetArea()
    {
        return rectangle.CalculateArea();
    }

    public long GetPerimeter()
    {
        return rectangle.CalculatePerimeter();
    }

    public void Move(long dx, long dy)
    {
        rectangle.Shift((int)dx, (int)dy);
    }
}

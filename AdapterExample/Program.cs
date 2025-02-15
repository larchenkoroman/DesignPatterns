using AdapterExample;

void CenterRectangle(IRectangle rectangle)
{
    Console.WriteLine("Moving to the center");
}

LegacyRectangle legacyRectangle = new(0, 0, 100, 50);
IRectangle rectangle = new LegacyRectangleAdapter(legacyRectangle);
CenterRectangle(rectangle);


using System.IO.Enumeration;

IImage image1 = new ProxyImage(FileSystemName: "image1");
IImage image2 = new ProxyImage(FileSystemName: "image2");

Console.WriteLine("Displaying image1");
image1.Display();

Console.WriteLine("Displaying image2");
image2.Display();

Console.WriteLine("Displaying image1 again");
image1.Display();

Console.WriteLine("Displaying image1 again");
image1.Display();

Console.WriteLine("Displaying image1 again");
image1.Display();

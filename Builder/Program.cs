using Builder;
using Builder.Builders;

IBuilder builder = new ComplexProductBuilder();
builder.BuildName();
builder.BuildDescription();

Product product = builder.Build();
Console.WriteLine($"Name: {product.Name}. Description: {product.Description}");
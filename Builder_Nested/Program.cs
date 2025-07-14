using Builder_Nested;

Product product = new Product.Builder()
                     .SetName("1111")
                     .SetDescription("222")
                     .Build();

Console.WriteLine(product);



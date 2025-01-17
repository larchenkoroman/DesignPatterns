using Interpreter;

int result = new AddExpression(new NumberExpression(1), 
                               new MultiplyExpression(new NumberExpression(2), 
                                                      new NumberExpression(3)
                                                     )
                              ).Interpret();
Console.WriteLine(result.ToString());
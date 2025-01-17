using InterpreterSearchQueryLanguage;

List<string> words = new List<string>() { "Hello", "world", "elephant", "help" };

List<string> result = new AndExpression(new NotWordExpression("hello"),
                                        new ContainsExpression("el")
                                       )
                            .Interpret(words);

foreach(string word in result)
    Console.WriteLine(word);
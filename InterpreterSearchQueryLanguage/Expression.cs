﻿namespace InterpreterSearchQueryLanguage;
public abstract class Expression
{
    public abstract List<string> Interpret(List<string> words);
}

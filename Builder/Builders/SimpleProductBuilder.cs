namespace Builder.Builders;

public class SimpleProductBuilder : IBuilder
{
    private string _name;
    private string _description;

    public Product Build()
    {
        return new Product(Name: _name, Description: _description);
    }

    public void BuildDescription()
    {
        _description = "This is the SimpleProductBbuilder";
    }

    public void BuildName()
    {
        _name = "SimpleProductBuilder";
    }
}

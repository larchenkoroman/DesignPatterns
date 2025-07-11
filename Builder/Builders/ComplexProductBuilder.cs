namespace Builder.Builders;

public class ComplexProductBuilder : IBuilder
{
    private string _name;
    private string _description;

    public Product Build()
    {
        return new Product(Name: _name, Description: _description);
    }

    public void BuildDescription()
    {
        _description = "This is the ComplexProductBbuilder";
    }

    public void BuildName()
    {
        _name = "ComplexProductBuilder";
    }
}

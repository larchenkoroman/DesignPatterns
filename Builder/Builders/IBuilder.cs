namespace Builder.Builders;

public interface IBuilder
{
    void BuildName();
    void BuildDescription();
    Product Build();
}

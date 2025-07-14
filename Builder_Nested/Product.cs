using System.Xml.Linq;

namespace Builder_Nested;

public record Product(string Name, string Description)
{
    public class Builder
    {
        private string _name = "";
        private string _description = "";
        public Product Build() => new Product(_name, _description);

        public Builder SetDescription(string description)
        {
            _description = description;
            return this;
        }

        public Builder SetName(string name)
        {
            _name = name;
            return this;
        }
    }
}

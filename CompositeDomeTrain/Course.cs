
namespace CompositeDomeTrain;

public class Course(string name, TimeSpan duration, Decimal price) : LearningResourse
{
    public override TimeSpan GetDuration() => duration;

    public override string GetName() => name;

    public override decimal GetPrice() => price;
}

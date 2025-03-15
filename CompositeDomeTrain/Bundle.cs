
namespace CompositeDomeTrain;

public class Bundle(string name) : LearningResourse
{
    private List<LearningResourse> _children = [];
    public override TimeSpan GetDuration()
    {
        return new TimeSpan(_children.Sum(x => x.GetDuration().Ticks));
    }

    public override string GetName() => name;

    public override decimal GetPrice()
    {
        return _children.Sum(x => x.GetPrice()) * 0.8m;
    }
    public override void AddLearningResourse(LearningResourse learningResourse) => _children.Add(learningResourse);
    public override void RemoveLearningResourse(LearningResourse learningResourse) => _children.Remove(learningResourse);
    public override LearningResourse GetLearningResourse(string name) => _children.SingleOrDefault(x => x.GetName() == name);
}

namespace CompositeDomeTrain;

public abstract class LearningResourse
{
    public abstract string GetName();
    public abstract decimal GetPrice();
    public abstract TimeSpan GetDuration();
    public virtual void AddLearningResourse(LearningResourse learningResourse) { }
    public virtual void RemoveLearningResourse(LearningResourse learningResourse) { }
    public virtual LearningResourse? GetLearningResourse(string name) 
    { 
        return null; 
    }
}

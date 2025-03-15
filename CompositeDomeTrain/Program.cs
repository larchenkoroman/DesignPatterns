using CompositeDomeTrain;

LearningResourse root = new Bundle("Zero to hero PostgreSql");

LearningResourse LeafA = new Course(
    name: "Getting started", 
    duration: TimeSpan.FromHours(3), 
    price: 100);

LearningResourse LeafB = new Course(
    name: "Advanced...", 
    duration: TimeSpan.FromHours(4), 
    price: 110);

root.AddLearningResourse(LeafA);
root.AddLearningResourse(LeafB);

Console.WriteLine(root.GetPrice());
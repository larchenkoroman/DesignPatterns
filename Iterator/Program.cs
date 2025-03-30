using Iterator;

Aggregate<string> aggregate = new ConcreteAggregate<string>();
aggregate.Add("1_");
aggregate.Add("2_");
aggregate.Add("3_");

Iterator.Iterator<string> iterator = aggregate.CreateIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}
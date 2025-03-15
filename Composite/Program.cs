using Composite;

Component root = new Compozite();
Component leafA = new Leaf();
root.Add(leafA);

Component childComposite = new Compozite();
Component leafB = new Leaf();
Component leafC = new Leaf();
childComposite.Add(leafB);
childComposite.Add(leafC);

root.Add(childComposite);
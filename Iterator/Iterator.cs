namespace Iterator;

public interface Iterator<T>
{
    void Reset();
    bool HasNext();
    T Next();
}

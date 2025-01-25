Singlenton singlenton1 = Singlenton.Instance;
Singlenton singlenton2 = Singlenton.Instance;
Singlenton singlenton3 = Singlenton.Instance;

sealed class Singlenton
{
    private static readonly Lazy<Singlenton> _lazyInstance = new(() => new Singlenton());

    public static Singlenton Instance => _lazyInstance.Value;
    private Singlenton() 
    {
        Console.WriteLine("Instaciating Singlenton");
    }
}
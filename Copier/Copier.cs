public interface ISource
{
    char ReadChar();
}

public interface IDestination
{
    void WriteChar(char c);
}

public class Copier
{
    private readonly ISource _source;
    private readonly IDestination _destination;

    public Copier(ISource source, IDestination destination)
    {
        _source = source;
        _destination = destination;
    }

    public void Copy()
    {
        while (true)
        {
            char c = _source.ReadChar();
            if (c == '\n') break;
            _destination.WriteChar(c);
        }
    }
}

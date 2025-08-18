namespace cfGameEngine.GameItem;

public interface IGameItem { }

public class GameItemFactoryInstance
{
    public delegate IGameItem Decoder(ReadOnlySpan<string> args);
    
    private readonly Dictionary<string, Decoder> _decoders = new();
    
    public void Register(string typeName, Decoder decoder)
    {
        if (string.IsNullOrEmpty(typeName) || decoder == null)
            throw new ArgumentException("Type name and decoder cannot be null or empty.");

        if (!_decoders.TryAdd(typeName, decoder))
            throw new InvalidOperationException($"Decoder for type '{typeName}' is already registered.");
    }
    
    public IGameItem Decode(string typeName, ReadOnlySpan<string> args)
    {
        if (string.IsNullOrEmpty(typeName))
            throw new ArgumentException("Type name cannot be null or empty.");

        if (!_decoders.TryGetValue(typeName, out var decoder))
            throw new KeyNotFoundException($"No decoder registered for type '{typeName}'.");

        return decoder(args);
    }
}
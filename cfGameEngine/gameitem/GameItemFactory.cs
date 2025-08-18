namespace cfGameEngine.GameItem;

public static class GameItemFactory
{
    private static readonly GameItemFactoryInstance Instance = new();

    public static void Register(string name, GameItemFactoryInstance.Decoder decoder) => Instance.Register(name, decoder);

    public static IGameItem Decode(string name, ReadOnlySpan<string> args)
    {
        return Instance.Decode(name, args);
    }
}

namespace cfGameEngine.GameItem 
{
    [AttributeUsage(System.AttributeTargets.Class, Inherited = false)]
    public sealed class GameItemAttribute : Attribute
    {
        public string ItemName { get; }
        public string DecodeMethodName { get; }
        public GameItemAttribute(string itemName, string decodeMethodName)
        {
            ItemName = itemName;
            DecodeMethodName = decodeMethodName;
        }
    }
}

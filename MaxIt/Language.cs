namespace MaxIt
{
    internal class Language
    {
        internal int Id { get; set; } = -1;
        internal List<string> Name { get; set; } = new();
        internal Dictionary<string, string> Text { get; set; } = new();
    }
}

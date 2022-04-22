class Color
{
    public string Value { get; set; }

    public Color(string value)
    {
		Console.WriteLine($"Color \"{value}\" constructed");
        Value = value;
    }

	public override string ToString()
	{
		return Value;
	}
}

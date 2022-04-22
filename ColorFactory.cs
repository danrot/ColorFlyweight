class ColorFactory
{
	private Dictionary<string, Color> colors = new Dictionary<string, Color>();

	public Color GetColor(string value)
	{
		if (!colors.ContainsKey(value)) {
			colors.Add(value, new Color(value));
		}

		return colors[value];
	}
}

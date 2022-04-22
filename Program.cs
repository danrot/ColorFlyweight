var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ColorFactory>();

var app = builder.Build();

app.MapGet("/color/{color}", (ColorFactory colorFactory, string color) => {
	Color colorValueObject = colorFactory.GetColor(color);
	return $"Hello {colorValueObject.ToString()}!";
});

app.Run();

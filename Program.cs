var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "DIVIDE AÍ CARALHOOOOOOOOOOOOOOOWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW, FILHO DA PUTAAAAAAAAAAAAAAAA!!!!!!!!!!!!!!!!!");
app.MapGet("/pessoas", () => "Listagem Pessoas");
app.MapGet("/itens", () => "Listagem Itens");

app.Run();

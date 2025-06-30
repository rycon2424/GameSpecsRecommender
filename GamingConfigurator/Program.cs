using GamingConfigurator.Services;
using Microsoft.OpenApi.Models;
using System.Net.WebSockets;
using System.Text.Json;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddSingleton<RecommendationService>();
builder.Services.AddControllers();

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Gaming Configurator API",
        Version = "v1",
        Description = "API for recommending gaming desktops based on user needs."
    });
});

builder.Services.AddSingleton<RecommendationService>();

var app = builder.Build();

// Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gaming Configurator API v1");
});

// Websockets
// Enable WebSockets
var webSocketOptions = new WebSocketOptions
{
    KeepAliveInterval = TimeSpan.FromSeconds(120)
};
app.UseWebSockets(webSocketOptions);

app.MapControllers();

// WebSocket route
app.Map("/ws/recommend", async context =>
{
    if (context.WebSockets.IsWebSocketRequest)
    {
        var webSocket = await context.WebSockets.AcceptWebSocketAsync();
        var service = context.RequestServices.GetRequiredService<RecommendationService>();

        var buffer = new byte[1024 * 4];
        while (true)
        {
            var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

            if (result.MessageType == WebSocketMessageType.Close)
            {
                await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closed by client", CancellationToken.None);
                break;
            }

            var requestJson = Encoding.UTF8.GetString(buffer, 0, result.Count);
            var query = JsonSerializer.Deserialize<RecommendationQuery>(requestJson);

            var matches = service.GetRecommendations(query?.UseCase, query?.MaxPrice);
            var responseJson = JsonSerializer.Serialize(matches);

            await webSocket.SendAsync(
                new ArraySegment<byte>(Encoding.UTF8.GetBytes(responseJson)),
                WebSocketMessageType.Text,
                true,
                CancellationToken.None
            );
        }
    }
    else
    {
        context.Response.StatusCode = 400;
    }
});

// To use the wwwroot
app.UseStaticFiles();

app.UseHttpsRedirection();

app.MapControllers(); 

app.MapFallbackToFile("index.html");

app.Run();

record RecommendationQuery(string UseCase, int? MaxPrice);
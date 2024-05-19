using AlbumAPI;

var builder = WebApplication.CreateBuilder();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => {
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.MapGet("/", async context =>
{
    await context.Response.WriteAsync("Hit the /albums endpoint to retrieve a list of albums!");
});

app.MapGet("/albums", () =>
{
    return Album.GetAll();
})
.WithName("GetAlbums");

app.MapGet("/albumsfunny", () =>
{
    return new FunnyService().GetFunnyAlbums();
});

app.Run();

record Album(int Id, string Title, string Artist, double Price, string Image_url)
{
     public static List<Album> GetAll(){
         var albums = new List<Album>(){
            new Album(1, "Fairly Suggestion", "Twenty One CoPilots", 19.00, "https://upload.wikimedia.org/wikipedia/commons/8/8a/GitHub_Copilot_logo.svg"),
            new Album(2, "You, Me and an App Id", "Daprize", 10.99, "https://aka.ms/albums-daprlogo"),
            new Album(3, "Seven Revision Army", "The Blue-Green Stripes", 13.99, "https://aka.ms/albums-containerappslogo"),
            new Album(4, "Scale It Up", "KEDA Club", 13.99, "https://aka.ms/albums-kedalogo"),
            new Album(5, "Lost in Translation", "MegaDNS", 12.99,"https://aka.ms/albums-envoylogo"),
            new Album(6, "Lock Down Your Love", "V is for VNET", 12.99, "https://aka.ms/albums-vnetlogo"),
            new Album(7, "Sweet Container O' Mine", "Guns N Probeses", 14.99, "https://aka.ms/albums-containerappslogo")
            
            
         };

        

        return albums; 
     }
}
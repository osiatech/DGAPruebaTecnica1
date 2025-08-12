


using Infraestructure.DGA.Context;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();


        var connectionStrings = builder.Configuration.GetConnectionString("DGAPruebaTecnicaContext");
        builder.Services.AddSqlServer<Project1DbContext>(connectionStrings);


        var app = builder.Build();

        app.Run();
    }
}







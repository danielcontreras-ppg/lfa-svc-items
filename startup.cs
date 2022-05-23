public class Startup

{

    public void ConfigureServices(IServiceCollection services)

    {

        services.AddCors();

    }



    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)

    {
    app.UseCors(builder =>
    {
        builder
        .WithOrigins("http://localhost:8080/")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .SetIsOriginAllowed(origin => true);
    });

    }

}
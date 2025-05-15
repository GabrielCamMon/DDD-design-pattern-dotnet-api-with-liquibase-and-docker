public static class WebAppExtensions
{
    public static void ConfigurePipeline(this WebApplication app)
    {
        // 👇 Swagger SEMPRE disponível (mesmo em Production)
        app.UseSwagger();
        app.UseSwaggerUI(c => 
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyProject API v1");
            c.RoutePrefix = "swagger"; // Rota customizável (opcional)
        });

        app.UseHttpsRedirection();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
    }
}
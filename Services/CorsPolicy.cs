namespace SimpleAPI.Services
{
    public class CorsPolicy
    {
        public static void ConfigureCorsPolicy(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin", builder =>
                {
                    builder.WithOrigins("http://localhost:3000")
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });
        }
    }
}

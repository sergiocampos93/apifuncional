namespace ApiFuncional.Configuration
{
    public static class ApiConfig
    {
        public static WebApplicationBuilder AddApiConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers()
                            .ConfigureApiBehaviorOptions(option =>
                            {
                                option.SuppressModelStateInvalidFilter = true;
                            });
            return builder;
        }
    }
}

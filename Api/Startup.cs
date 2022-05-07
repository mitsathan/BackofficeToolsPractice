namespace Api
{
	public class Startup
	{
		public Startup(IConfigurationRoot configuration)
		{
			Configuration = configuration;
		}

		public IConfigurationRoot Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseSwagger();
			app.UseSwaggerUI();
			app.UseHttpsRedirection();

			app.UseRouting();
			app.UseAuthorization();
			app.UseEndpoints(x => x.MapControllers());
		}
	}
}

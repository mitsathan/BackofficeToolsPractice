using Api;

var loggerFactory = LoggerFactory.Create(
	builder => builder
		// add console as logging target
		.AddConsole()
		// add debug output as logging target
		.AddDebug()
		// set minimum level to log
		.SetMinimumLevel(LogLevel.Debug)
);
var logger = loggerFactory.CreateLogger<Program>();

try
{
	var builder = WebApplication.CreateBuilder(args);
	var startup = new Startup(builder.Configuration);
	startup.ConfigureServices(builder.Services);
	var app = builder.Build();
	startup.Configure(app);
	app.Run();
}
catch (Exception ex)
{
	logger.LogError(ex, "An error occurred while starting the api.");

	throw;
}

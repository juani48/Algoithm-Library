using Microsoft.Extensions.Logging;
using Solution.Aplication;
using Solution.Aplication.Interface;
using Solution.Aplication.UseCase.Algorithm;
using Solution.Aplication.UseCase.Cube;
using Solution.Repository;

namespace Solution.MAUI_Blazor;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

		//Cube case use
		builder.Services.AddTransient<CubeUseCaseAdd>();
		builder.Services.AddTransient<CubeUseCaseDelete>();
		builder.Services.AddTransient<CubeUseCaseGet>();
		builder.Services.AddTransient<CubeUseCaseList>();
		//Algorithm case use
		builder.Services.AddTransient<AlgorithmUseCaseAdd>();
		builder.Services.AddTransient<AlgorithmUseCaseDelete>();
		builder.Services.AddTransient<AlgorithmUseCaseGet>();
		builder.Services.AddTransient<AlgorithmUseCaseList>();
		//Repository
		builder.Services.AddSingleton<IRepositoryCube, CubeRepository>();
		builder.Services.AddSingleton<IRepositoryAlgorithm, AlgorithmRepository>();
		//Initialization
		CubeRepository.Initialization();
		AlgorithmRepository.Initialization();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

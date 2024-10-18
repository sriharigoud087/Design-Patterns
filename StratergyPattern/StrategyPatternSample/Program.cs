
using StrategyPatternSample.Services;

namespace StrategyPatternSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IFileProcessing, CsvFileProcessorService>();
            builder.Services.AddSingleton<IFileProcessing, PdfFileProcessorService>();
            builder.Services.AddSingleton<IFileProcessing, JpgFileProcessorService>();
            builder.Services.AddSingleton<IFileProcessing, XlsxFileProcessorService>();
            builder.Services.AddSingleton<FileProcessorFactory>();
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

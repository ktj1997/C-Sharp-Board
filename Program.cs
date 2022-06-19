using Serilog;

namespace C_Sharp_Board
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(
              webBuilder =>
              {
                  webBuilder.UseSerilog((ctx, lc) => lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));
                  webBuilder.UseStartup<StartUp>();
              }
            );
        }
    }
}
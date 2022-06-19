using C_Sharp_Board.Config;
using C_Sharp_Board.Controller;
using C_Sharp_Board.Repository;
using C_Sharp_Board.Service;
using Microsoft.EntityFrameworkCore;


/**
  * IOC Container
  */
class StartUp
{
    private IConfiguration _configuration { get; }

    public StartUp(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /**
	  * Dependency Injection 코드
	  */
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc().AddControllersAsServices();
        services.AddEndpointsApiExplorer();

        services.AddScoped<UserController>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<UserRepository, UserRepository>();

        services.AddCors(options =>
        {
            options.AddPolicy(name: "AllowAll",
            policy => policy.AllowAnyHeader()
            .AllowAnyOrigin()
            .AllowAnyMethod());
        });
        services.AddEndpointsApiExplorer();
        //swagger 생성기
        services.AddSwaggerGen();

        /**
		  * DB Configuration Code Injection && Migration 프로젝트 지정
		  * Migration ==> Application DataModel과 DB Entity의 동기상태 유지 및 DB 기존 데이터 보존 목적이다. 
		 */
        services.AddDbContext<CodeFirstDbContext>(options =>
        {
            options.UseSqlServer(
                connectionString: _configuration.GetConnectionString("CodeFirstDbConnectionString")
            );
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseRouting();
        app.UseCors("AllowAll");
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
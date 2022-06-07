using Board.Config;
using Board.Controller;
using Board.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

/**
  * IOC Container
  */
class StartUp{
    public IConfiguration _configuration {get;}

    public StartUp(IConfiguration configuration){
        _configuration = configuration;
    }

    /**
      * Dependency Injection 코드
      */
    public void ConfigureServices(IServiceCollection services){
        services.AddMvc().AddControllersAsServices();
        services.AddEndpointsApiExplorer();
        services.AddSingleton<UserController>();
        services.AddSingleton<IUserService,UserService>();
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

        services.AddDbContext<DefaultDbContext>(options =>
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultDbConnectionString") );
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env){
        if(env.IsDevelopment()){
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseRouting();
        app.UseCors("AllowAll");
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>{
            endpoints.MapControllers();
        });
    }
}
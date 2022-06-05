using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/**
	* Builder는 App을 실행하기 위해서 필요한
	* 모든 설정들을 관리한다.
	* IOC Container 역할을 한다.
	*/
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//swagger 생성기
builder.Services.AddSwaggerGen();
//Cors 설정 등록
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowAll",
    policy => policy.AllowAnyHeader()
    .AllowAnyOrigin()
    .AllowAnyMethod());
});

/**
  * ctx: builder
  * --> ctx의 Configuration은 appsettings.json 파일을 가르킨다.
  * lc : logger Configuration
  */
builder.Host.UseSerilog((ctx, lc) => lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/**
    * 실제 작동하는 App에서 설정들을 적용한다.
    */

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();

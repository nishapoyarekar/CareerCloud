using CareerCloud.gRPC.Services;

namespace CareerCloud.gRPC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddGrpc();

            builder.Services.AddHttpClient("productApi", options =>
            {
                options.BaseAddress = new Uri(builder.Configuration.GetSection("ApiOptions:BaseAddress")!.Value);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<GreeterService>();
            app.MapGrpcService<ApplicantEducationService>();
            app.MapGrpcService<ApplicantJobApplicationService>();
            app.MapGrpcService<ApplicantProfileService>();
            app.MapGrpcService<CompanyDescriptionService>();
            app.MapGrpcService<CompanyJobService>();
            app.MapGrpcService<CompanyJobEducationService>();
            app.MapGrpcService<SecurityLoginService>();
            app.MapGrpcService<SecurityLoginsLogService>();
            app.MapGrpcService<SystemLanguageCodeService>();



            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();

        }
    }
}
using FirstProject.BL;
using FirstProject.DAL;
using FirstProject.MiddelWare;
namespace FirstProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            // connect DB
            builder.Services.AddDataAccessLayer(builder.Configuration);

            // Add services to the container.
            builder.Services.AddBussinesLogic();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            //////////MiddleWare///////////////////

            app.Use(async (next, context) =>
            {
                Console.Write("inline middelware bfore 1");
                //logic before
                await context.Invoke(next);

                //logic after
                Console.Write("inline middelware after 1");

            });

            //////////another MiddleWare///////////////////
            app.UseMiddleware<TestMiddelware>();


            app.UseAuthorization();

            //mvc middelware
            app.MapControllers();

            app.Run();

            //during middelware the httpcontext body still json not c# object  [modelbinding]
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace JacksParkingBackEnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            ParkingSpot[] vSpots = new ParkingSpot[3];
            //when filling, decide if diagonal is top left or bottom right
            vSpots[0] = new ParkingSpot(379, 328, 362, 356, false); //empty, bottom left
            vSpots[1] = new ParkingSpot(478, 325, 550, 359, true);//513, 323, 519, 356); old values //red car, top left
            vSpots[2] = new ParkingSpot(215, 325, 169, 357, false); //white challenger with silver hood
            Bitmap Village = new Bitmap("Resources/images/lot_image.png");
            ParkingLot village = new ParkingLot("Resources/images/lot_image.png", vSpots, Village);
            System.Diagnostics.Debug.WriteLine(village.spotsStatus());


            //Glenn Test
            //double[] rValues = Bitmapping.getR(Village, 379, 328, 362, 356, vSpots[0].getLength(), 0);
            //double[] standardOfComparison = Calculations.confidenceInterval(rValues);
            //Calculations.IsAvailable(standardOfComparison, rValues);

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container. Register dependencies here.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}

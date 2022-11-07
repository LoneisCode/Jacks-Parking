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

            ParkingSpot[] vSpots = new ParkingSpot[14];
            // When filling, decide if diagonal is starting from top left or bottom left. 
            // Parking spot numbers correspond to a personal list Jessie has written. 
            vSpots[0] = new ParkingSpot(119, 325, 35, 358, false); // Spot 1, empty
            vSpots[1] = new ParkingSpot(446, 325, 515, 359, true); // Spot 12, empty
            vSpots[2] = new ParkingSpot(182, 326, 125, 358, false); // Spot 3, taken
            vSpots[3] = new ParkingSpot(217, 325, 165, 357, false); // Spot 4, taken
            vSpots[4] = new ParkingSpot(252, 324, 206, 358, false); // Spot 5, taken
            vSpots[5] = new ParkingSpot(284, 324, 243, 358, false); // Spot 6, taken
            vSpots[6] = new ParkingSpot(317, 468, 284, 357, false); // Spot 7, taken
            vSpots[7] = new ParkingSpot(350, 319, 324, 358, false); // Spot 8, taken
            vSpots[8] = new ParkingSpot(381, 324, 362, 358, false); // Spot 9, empty
            vSpots[9] = new ParkingSpot(419, 319, 401, 358, false); // Spot 10, taken
            vSpots[10] = new ParkingSpot(425, 323, 376, 358, true); // Spot 11, empty, NOT REGISTERING AS EMPTY
            vSpots[11] = new ParkingSpot(144, 328, 82, 358, false); // Spot 2, empty
            vSpots[12] = new ParkingSpot(477, 324, 551, 358, true); // Spot 13, taken
            vSpots[13] = new ParkingSpot(518, 320, 584, 358, true); // Spot 14, taken
            
            Bitmap Village = new Bitmap("Resources/images/lot_image.jpg");
            ParkingLot village = new ParkingLot("Resources/images/lot_image.jpg", vSpots, Village);
            System.Diagnostics.Debug.WriteLine(village.SpotsStatus());

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

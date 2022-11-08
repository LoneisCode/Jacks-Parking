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

            ParkingSpot[] vSpots = new ParkingSpot[36];
            // When filling, decide if diagonal is starting from top left or bottom left. 
            // Parking spot numbers correspond to a personal list Jessie has written. 
            // First row from the bottom up. 
            vSpots[0] = new ParkingSpot(119, 325, 35, 358, false); // Spot 1, empty || 1
            vSpots[1] = new ParkingSpot(446, 325, 515, 359, true); // Spot 12, empty || 2
            vSpots[11] = new ParkingSpot(144, 328, 82, 358, false); // Spot 2, empty || 3
            vSpots[2] = new ParkingSpot(182, 326, 125, 358, false); // Spot 3, taken
            vSpots[3] = new ParkingSpot(217, 325, 165, 357, false); // Spot 4, taken
            vSpots[4] = new ParkingSpot(252, 324, 206, 358, false); // Spot 5, taken
            vSpots[5] = new ParkingSpot(284, 324, 243, 358, false); // Spot 6, taken
            vSpots[6] = new ParkingSpot(317, 468, 284, 357, false); // Spot 7, taken
            vSpots[7] = new ParkingSpot(350, 319, 324, 358, false); // Spot 8, taken
            vSpots[8] = new ParkingSpot(381, 324, 362, 358, false); // Spot 9, empty || 4
            vSpots[9] = new ParkingSpot(419, 319, 401, 358, false); // Spot 10, taken
            vSpots[10] = new ParkingSpot(425, 323, 376, 358, true); // Spot 11, empty || 5
            vSpots[12] = new ParkingSpot(477, 324, 551, 358, true); // Spot 13, taken
            vSpots[13] = new ParkingSpot(518, 320, 584, 358, true); // Spot 14, taken
            // Second row from the bottom up.
            vSpots[14] = new ParkingSpot(126, 273, 90, 287, false); // Spot 15, empty || 6
            vSpots[15] = new ParkingSpot(139, 273, 110, 287, false); // Spot 16, taken
            vSpots[16] = new ParkingSpot(162, 273, 130, 287, false); // Spot 17, taken
            vSpots[17] = new ParkingSpot(187, 273, 156, 287, false); // Spot 18, taken
            vSpots[18] = new ParkingSpot(213, 277, 180, 287, false); // Spot 19, taken
            vSpots[19] = new ParkingSpot(236, 277, 207, 287, false); // Spot 20, taken
            vSpots[20] = new ParkingSpot(260, 277, 232, 287, false); // Spot 21, taken
            vSpots[21] = new ParkingSpot(282, 277, 258, 287, false); // Spot 22, taken
            vSpots[22] = new ParkingSpot(305, 277, 282, 287, false); // Spot 23, taken
            vSpots[23] = new ParkingSpot(327, 277, 306, 287, false); // Spot 24, empty || 7
            vSpots[24] = new ParkingSpot(349, 277, 332, 287, false); // Spot 25, taken
            vSpots[25] = new ParkingSpot(371, 277, 355, 287, false); // Spot 26, taken
            vSpots[26] = new ParkingSpot(394, 275, 379, 291, false); // Spot 27, taken
            vSpots[27] = new ParkingSpot(414, 277, 405, 291, false); // Spot 28, taken
           




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

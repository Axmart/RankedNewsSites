using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RankedNewsSites.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RankedNewsSites.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {

            using(var context = new RankedNewsSitesContext(serviceProvider.GetRequiredService<DbContextOptions<RankedNewsSitesContext>>()))
            {

                if (context.NewsSite.Any())
                {
                    return;
                }

                context.NewsSite.AddRange(
                    new NewsSite() { Name="Esport 1", PictureSource="/images/esport1.png", Points=50, Url= "https://esport1.hu/" },
                    new NewsSite() { Name="GameStar", PictureSource="/images/gamestar.png", Points=40, Url= "https://www.gamestar.hu/" },
                    new NewsSite() { Name="IGN Hungary", PictureSource="/images/ignhungary.png", Points=32, Url= "https://hu.ign.com/" },
                    new NewsSite() { Name="Index", PictureSource="/images/index.png", Points=32, Url= "https://index.hu/" },
                    new NewsSite() { Name="Leet", PictureSource="/images/leet.png", Points=25, Url= "https://leet.hu/" },
                    new NewsSite() { Name="Metabro", PictureSource="/images/metabro.png", Points=15, Url= "https://metabro.hu/" },
                    new NewsSite() { Name="Origo", PictureSource="/images/origo.png", Points=22, Url= "https://www.origo.hu/index.html" },
                    new NewsSite() { Name="Pc Guru Online", PictureSource="/images/pcguruonline.png", Points=37, Url= "https://www.pcguru.hu/" }
                    
                    
                    
                    
                    );

                context.SaveChanges();

            }



        }

    }
}

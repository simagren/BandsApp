using BandsApp.Web.Models;
using static System.Net.Mime.MediaTypeNames;

namespace BandsApp.Web.Services
{
    public class BandService
    {
        List<Band> bands = [
            new Band { Id = 1, Name = "Rammstein", Description = "A heavy metal band", ImageUrl = "/Images/rammstein.jpg", Albums = ["Mutter","Zeit","Rammstein"] },
            new Band { Id = 2, Name = "AC/DC", Description = "Rock n Roll band", ImageUrl = "/Images/acdc.jpg", Albums = ["Back in Black", "High Voltage", "Highway to hell"] },
            new Band { Id = 3, Name = "Iron Maiden", Description = "Heavy metal band" , ImageUrl = "/Images/ironmaiden.jpg", Albums =["Fear of the dark", "Powerslave", "The number of the beasty"]},
            new Band { Id = 4, Name = "Kent", Description = "Swedish pop band", ImageUrl = "/Images/kent.jpg", Albums =["Du & jag döden", "Kent" , "Tillbaka till framtiden"] }
            ];

        public Band[] GetAllBands() => bands
            .OrderBy(b => b.Name)
            .ToArray();

        public Band? GetBandById(int id) => bands
         .SingleOrDefault(b => b.Id == id);
    }
}

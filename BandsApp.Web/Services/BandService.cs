using BandsApp.Web.Models;
using static System.Net.Mime.MediaTypeNames;

namespace BandsApp.Web.Services
{
    public class BandService
    {
        List<Band> bands = [
            new Band { Id = 1, Name = "Rammstein", Description = "A heavy metal band", ImageUrl = "/Images/rammstein.jpg" },
            new Band { Id = 2, Name = "AC/DC", Description = "Rock n Roll band", ImageUrl = "/Images/acdc.jpg" },
            new Band { Id = 3, Name = "Iron Maiden", Description = "Heavy metal band" , ImageUrl = "/Images/ironmaiden.jpg"},
            new Band { Id = 4, Name = "Kent", Description = "Swedish pop band", ImageUrl = "/Images/kent.jpg"}
            ];

        public Band[] GetAllBands() => bands
            .OrderBy(b => b.Name)
            .ToArray();

        public Band? GetBandById(int id) => bands
         .SingleOrDefault(b => b.Id == id);
    }
}

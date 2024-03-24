namespace EntityFrameworkCore.Domain
{
    public class LeagueList : List<League>
    {
        public List<League> Leagues { get; set; } = new List<League>()
        {
            new League()
            {
                Id = 1,
                Name="Jamica Premiere League ",
            },
            new League()
            {
                Id=2,
                Name="English Premier League",

            },
            new League()
            {
                Id=3,
                Name= "La Liga"
            }


        };
    }
}

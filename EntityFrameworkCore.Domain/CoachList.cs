namespace EntityFrameworkCore.Domain
{
    public class CoachList : List<Coach>

    {
        public List<Coach> Coaches { get; set; } = new List<Coach>()
        {
            new Coach(){Id=1, Name="Emad",},
            new Coach(){Id=2, Name="Mama",},
            new Coach(){Id=3, Name="Remon"},
            new Coach(){Id=4, Name="Morkso"},
            new Coach(){Id=5, Name="Baba"},
            new Coach(){Id=6, Name="Mina"},
            new Coach(){Id=7, Name="Kera"},
            new Coach(){Id=8, Name="Fady"},

        };
    }

}

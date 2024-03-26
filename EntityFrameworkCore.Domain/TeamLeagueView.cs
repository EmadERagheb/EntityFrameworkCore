namespace EntityFrameworkCore.Domain
{
    public class TeamLeagueView
    {
    
        public string LeagueName {  get; set; }

        public string TeamName { get; set; }
        public override string ToString()
       => $"{{LeagueName:{LeagueName}, TeamName:{TeamName}}}";
    }
}

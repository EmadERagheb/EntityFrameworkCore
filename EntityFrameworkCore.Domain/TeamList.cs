namespace EntityFrameworkCore.Domain
{
    public class TeamList : List<Team>
    {
        public List<Team> Teams { get; set; } = new List<Team>()
     {
         new Team(){Id=1,Name="Tivoli Garden F.C." ,CreatedDate=DateTimeOffset.UtcNow.DateTime},
         new Team(){Id=2,Name="Waterhourse  F.C." ,CreatedDate=DateTimeOffset.UtcNow.DateTime},
         new Team(){Id=3,Name="Humble Lions F.C." ,CreatedDate=DateTimeOffset.UtcNow.DateTime}
     };

    }
}

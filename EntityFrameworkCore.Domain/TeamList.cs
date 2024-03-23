namespace EntityFrameworkCore.Domain
{
    public class TeamList : List<Team>
    {
        public List<Team> Teams { get; set; } = new List<Team>()
     {
         new Team(){Id=1,Name="Tivoli Garden F.C." ,CreatedDate=DateTimeOffset.UtcNow.DateTime},
         new Team(){Id=2,Name="Waterhourse  F.C." ,CreatedDate=DateTimeOffset.UtcNow.DateTime},
         new Team(){Id=3,Name="Humble Lions F.C." ,CreatedDate=DateTimeOffset.UtcNow.DateTime},
         new Team(){Id=4,Name="Chelsea F.C." ,CreatedDate=DateTimeOffset.UtcNow.DateTime},
         new Team(){Id=5,Name="Real Madrid " ,CreatedDate=DateTimeOffset.UtcNow.DateTime},
         new Team(){Id=6,Name="Inter Milan" ,CreatedDate=DateTimeOffset.UtcNow.DateTime},
         new Team(){Id=7,Name="Inter Miami" ,CreatedDate=DateTimeOffset.UtcNow.DateTime},
         new Team(){Id=8,Name="Seba United" ,CreatedDate=DateTimeOffset.UtcNow.DateTime},
     };

    }
}

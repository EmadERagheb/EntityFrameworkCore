namespace EntityFrameworkCore.Domain
{
    public class Team : BaseDomainModel
    {
        #region Columns

        public string Name { get; set; }

        public int? LeagueId { get; set; }

        public int CoachId { get; set; }

        #endregion


        #region Relations
        #region League-Team 
        //League has many teams but team can only be exist on one league
        //optional relationship
        //column LeagueId
        //navigation Property
        public League? League { get; set; }

        #endregion
        #region HomeTeam-Match
        //Home Team  has many Maches
        //total relationShip
        // nocolumn
        //navigation Property
        public List<Match> HomeTeamMatches { get; set; }= new List<Match>();    
        #endregion  
        #region AwayTeam-Match
        //Away Team  has many Maches
        //total relationShip
        // nocolumn
        //navigation Property
        public List<Match> AwayTeamMatches { get; set; } = new List<Match>();
        #endregion
        #region Team-Coash
        //Team must have One Coach
        //Required
        //column CoachID
        //Navication Property
        public Coach Coach { get; set; }
        #endregion
        #endregion
    }
}

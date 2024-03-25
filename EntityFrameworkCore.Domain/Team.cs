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
        public virtual League? League { get; set; }

        #endregion
        #region HomeTeam-Match
        //Home Team  has many Matches
        //total relationShip
        // no column
        //navigation Property
        public virtual List<Match> HomeTeamMatches { get; set; }= new List<Match>();    
        #endregion  
        #region AwayTeam-Match
        //Away Team  has many Matches
        //total relationShip
        // no column
        //navigation Property
        public virtual List<Match> AwayTeamMatches { get; set; } = new List<Match>();
        #endregion
        #region Team-Coach
        //Team must have One Coach
        //Required
        //column CoachID
        //Navigation Property
        public virtual Coach Coach { get; set; }
        #endregion
        #endregion
    }
}

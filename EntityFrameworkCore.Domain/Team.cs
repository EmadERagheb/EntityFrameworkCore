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
        //ccolumn LeagueId
        //navigation Property
        public League? League { get; set; }

        #endregion
        #endregion
    }
}

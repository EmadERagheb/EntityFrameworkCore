namespace EntityFrameworkCore.Domain
{
    public class Match : BaseDomainModel
    {
        #region Columns
        public int HomeTeamId { get; set; }

        public int AwayTeamId { get; set; }
        public decimal TicketPrice { get; set; }
        public int AwayTeamScore { get; set; }
        public int HomeTeamScore { get; set; }
        public DateTime Date { get; set; }
        #endregion
        #region Relations
        #region HomeTeam-Match
        //Match   has one HomeTeam
        //total relationShip
        // HomeTeamID
        //navigation Property
        public  virtual Team HomeTeam { get; set; }
        #endregion  
        #region AwayTeam-Match
        //Match   has one AwayTeam
        //total relationShip
        // AwayTeamID
        //navigation Property
        public virtual Team AwayTeam { get; set; }
        #endregion
        #endregion
    }
}

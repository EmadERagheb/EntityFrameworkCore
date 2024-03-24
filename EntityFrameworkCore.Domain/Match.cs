namespace EntityFrameworkCore.Domain
{
    public class Match : BaseDomainModel
    {
        #region Columns
        public int HomeTeamId { get; set; }

        public int AwayTeamId { get; set; }
        public decimal TicketPrice { get; set; }

        public DateTime Date { get; set; } 
        #endregion
    }
}

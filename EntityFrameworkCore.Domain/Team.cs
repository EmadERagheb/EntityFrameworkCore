namespace EntityFrameworkCore.Domain
{
    public class Team : BaseDomainModel
    {
        #region Columns

        public string Name { get; set; }

        public int LeagueId { get; set; }

        public int CoachId { get; set; }
        #endregion


    }
}

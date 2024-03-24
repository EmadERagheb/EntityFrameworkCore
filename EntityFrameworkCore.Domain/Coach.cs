namespace EntityFrameworkCore.Domain
{
    public class Coach:BaseDomainModel
    {
        #region Column
       
        public string Name { get; set; }
        
        public int TeamId { get; set; }
        #endregion

    }
}

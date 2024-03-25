namespace EntityFrameworkCore.Domain
{
    public class Coach:BaseDomainModel
    {
        #region Column
       
        public string Name { get; set; }
        
    
        #endregion
        #region Relations
        #region Team-Coach
        //Coach may have one Team
        //optional
        //nocolumn
        //navigation Property
        public Team? Team { get; set; } 
        #endregion
        #endregion

    }
}

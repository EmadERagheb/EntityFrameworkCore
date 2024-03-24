using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class League:BaseDomainModel
    {
        #region Columns
        public string Name { get; set; }
       

        #endregion
        #region Relations
        #region League-Team 
        //League has many teams but team can only be exist on one league
        //optional relationship
        //ccolumn not exist
        //navigation Property
        public List<Team>? Teams { get; set; }

        #endregion
        #endregion
    }
}

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
    }
}

using MyCustomProject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomProject.Entity
{
    [Table(TableName = "Categories", IdentityColumn = "CategoryID",IsActiveColumn = "IsActive",PrimaryColumn = "CategoryID",ForeignColumn ="blabla")]
    public class Categories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}

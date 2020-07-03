using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuckTaleSolutionTask.Models
{
    public class DatatableFilter
    {
        public int Start { get; set; }

        public int RowSize { get; set; }

        public string Search { get; set; }

        public string SortColumn { get; set; }

        public string SortDirection { get; set; }


        public DatatableFilter()
        {
            Start = 0;
            RowSize = 10;
            Search = "";
            SortColumn = "First Name";
            SortDirection = "descending";
        }
    }
}

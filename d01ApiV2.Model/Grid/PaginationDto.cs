using System;
using System.Collections.Generic;
using System.Text;

namespace d01ApiV2.Model.Grid
{
    public class PaginationDto
    {
        public long CurrentPageNo { get; set; }
        public long CurrentPageSize { get; set; }
        public long RecordCount { get; set; }
    }
}

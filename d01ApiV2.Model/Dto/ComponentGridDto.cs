using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace d01ApiV2.Model.Dto
{
    public class ComponentGridDto: ComponentDto
    {   
        public int ColumnGroupNo { get; set; }
        public int IsAllowSort { get; set; }
        public int IsAscending { get; set; }
    }
}


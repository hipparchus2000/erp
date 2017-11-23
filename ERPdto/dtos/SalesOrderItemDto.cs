﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPdto.dtos
{
    public class SalesOrderItemDto
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Submitted { get; set; }

    }
}

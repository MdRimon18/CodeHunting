﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GarmentsERP.Model
{
    public class MarketingTeamInfo
    {
        [Key]
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int TeamLeaderId { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Status { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GarmentsERP.Model
{
    public class DivisionProfile
    {
        [Key]
        public int   Id {get;set;}
        public string DivisionName{get;set;}
        public string  ShortName { get;set;}
        public int CompanyName { get; set; }
        public string Address{get;set;}
        public string ContactNumber { get;set;}
        public string  Remark { get;set;}
        public int  CountryId { get; set; }
        public string  Website { get;set;}
        public string  Status { get;set;}
        public string  Email { get;set;}
        public string ContactPerson { get;set;}
    }
}

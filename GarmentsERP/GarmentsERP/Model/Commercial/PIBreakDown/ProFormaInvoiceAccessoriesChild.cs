﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarmentsERP.Model.Commercial.PIBreakDown
{
    public class ProFormaInvoiceAccessoriesChild
    {
        public int Id { get; set; }
        public int PiAccessoriesMasterId { get; set; }
        public int Wo { get; set; }
        public string ItemGroup { get; set; }
        public string ItemDescription { get; set; }
        public string BrandOrSuppRef { get; set; }
        public string GmtsColor { get; set; }
        public string GmtsSize { get; set; }
        public string ItemColor { get; set; }
        public string ItemSize { get; set; }
        public string Uom { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
        public double Upcharge { get; set; }
        public double Discount { get; set; }


        public string Status { get; set; }

        public string EntryDate { get; set; }
        public string EntryBy { get; set; }

        public string ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public bool IsApproved { get; set; }

        public string ModifyiedDate { get; set; }
        public bool IsModifyied { get; set; }
        public string ModifyiedBy { get; set; }


    }
}

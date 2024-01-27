﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarmentsERP.Model.Inventory
{
    public class WovenFinishRollIssueReturn
    {
        public int Id { get; set; }
        public string SystemNo { get; set; }
        public string BarcodeNumber { get; set; }
        public string IssueNumber { get; set; }
        public int CompanyId { get; set; }
        public string ToStore { get; set; }
        public string TransferDate { get; set; }
        public string ChallanNo { get; set; }


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

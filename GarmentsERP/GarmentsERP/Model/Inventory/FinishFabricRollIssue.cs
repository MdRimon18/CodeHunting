﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarmentsERP.Model.Inventory
{
    public class FinishFabricRollIssue
    {
        public int Id { get; set; }
        public string IssueNo { get; set; }
        public int CompanyId { get; set; }
        public string ServiceSource { get; set; }
        public int ServiceCompany { get; set; }
        public string IssueDate { get; set; }
        public string IssuePurpose { get; set; }
        public string BatchNo { get; set; }
        public string ReqsnNo { get; set; }
        public string RollNumber { get; set; }
        public string StoreName { get; set; }


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
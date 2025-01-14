﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWH.Common.ViewModel
{
    public class CandidateViewModel
    {         
        public int CandidateId { get; set; }
        public string ClassRollNo { get; set; } = string.Empty;
        public string CandidateName { get; set; } = string.Empty;
        public string MobileNo { get; set; } = string.Empty;
        public string AlternateNo { get; set; } = string.Empty;
        public string EmailId { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string ICardNumber { get; set; } = string.Empty;
        public string GRNumber { get; set; } = string.Empty;
        public string RFId { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public string SectionName { get; set; } = string.Empty;
        public string ImpageUrl { get; set; } = string.Empty; 
    }
}


﻿using System.ComponentModel.DataAnnotations;
using YumaPos.Shared.Attributes;

namespace YumaPos.Tests.Load.Data.Models
{
    [Map]
    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        public int TaskId { get; set; }

    }
}
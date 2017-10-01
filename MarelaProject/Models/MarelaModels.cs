using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarelaProject.Models
{

    public class MarelaModels
    {
        public int ID { get; set; }
        [Required]
        [StringLength(maximumLength: 16)]
        [RegularExpression(@"[a-zA-Z]+\-+[a-zA-Z]+\-+\d{0,3}", ErrorMessage = "Investigation number must be in a form: \"COMBIS-Inv-001\"")]
        [Display(Name = "Investigation Number")]
        public string InvestigationNumber { get; set; }
        [Required]
        [StringLength(maximumLength: 25)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [StringLength(maximumLength: 25)]
        [Display(Name = "Malware Name")]
        public string MalwareName { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Created")]
        public DateTime? FirstDate { get; set; }
        [Display(Name = "Modified")]
        public DateTime? LastModification { get; set; }
        public string MD5 { get; set; }
        public string SHA1 { get; set; }
        public string SHA256 { get; set; }
        public string ssdeep { get; set; }
        [StringLength(maximumLength: 6)]
        [Display(Name = "File Type")]
        public string FileType { get; set; }
        [Display(Name = "File Size")]
        public int? FileSize { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

    }
    public static class PageValues
    {

        public static SelectList ItemsPerPageList
        {
            get
            {
                return (new SelectList(new ArrayList { 25, 50, 100},
                selectedValue: 25));
            }
        }

    }
}





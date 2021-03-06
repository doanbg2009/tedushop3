﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Alias { get; set; }

        public string Description { get; set; }

        public int? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        public string Image { get; set; }

        //public string MetaKeyword { get; set; }

        //public string MetaDescription { get; set; }

        //public DateTime? CreatedDate { get; set; }

        //public string CreatedBy { get; set; }

        //public DateTime? UpdatedDate { get; set; }

        //public string UpdatedBy { get; set; }

        //public bool Status { get; set; }

        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<Post> Posts { set; get; }
    }
}

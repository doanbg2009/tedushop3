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
    [Table("ProductCategories")]
    public class ProductCategory :  Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public int? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        //public string MetaKeyword { get; set; }

        //public string MetaDescription { get; set; }

        //public DateTime? CreatedDate { get; set; }

        //public string CreatedBy { get; set; }

        //public DateTime? UpdatedDate { get; set; }

        //public string UpdatedBy { get; set; }

        //public bool Status { get; set; }

        public bool HomeFlag { get; set; }

        public virtual IEnumerable<Product> Products { set; get; }

    }
}

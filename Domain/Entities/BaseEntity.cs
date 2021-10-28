using System;
using System.ComponentModel.DataAnnotations;
namespace My_company.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity() => DateAdded = DateTime.Now;
        [Required]
        public Guid Id { get; set; } 
        
        [Display(Name ="Title")]
        public virtual string Title { get; set; }
        
        [Display(Name = "SubTitle")]
        public virtual string SubTitle { get; set; }
        
        [Display(Name = "Text")]
        public virtual string Text { get; set; }

        [Display(Name = "Title Picture")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "MetaTitle")]
        public  string MetaTitle { get; set; }

        [Display(Name = "Meta Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "Meta KeyWords")]
        public string MetaKeyWords { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }


    }
}

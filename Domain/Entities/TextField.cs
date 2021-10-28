namespace My_company.Domain.Entities
{
    public class TextField : BaseEntity
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string CodeWord { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name ="Name of article")]
        public override string Title { get; set; }


        [System.ComponentModel.DataAnnotations.Display(Name = "article")]
        public override string Text { get; set; }
    }
}


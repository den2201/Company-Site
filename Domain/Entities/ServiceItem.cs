namespace My_company.Domain.Entities
{
    public class ServiceItem:BaseEntity
    {
        [System.ComponentModel.DataAnnotations.Display(Name = "Title of service")]
        public override string Title { get; set; }

        
        [System.ComponentModel.DataAnnotations.Display(Name = "short description  of service")]
        public override string SubTitle { get; set; }


        [System.ComponentModel.DataAnnotations.Display(Name = "article about service")]
        public override string Text { get; set; }
    }
}

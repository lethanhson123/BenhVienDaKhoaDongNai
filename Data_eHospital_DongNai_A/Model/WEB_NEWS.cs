namespace Data_eHospital_DongNai_A.Model
{
    public partial class WEB_NEWS : BaseModel
    {
        [Key]
        public int? News_ID { get; set; }
public string? Title { get; set; }
public string? TitleE { get; set; }
public string? Image { get; set; }
public string? Summarize { get; set; }
public string? Body { get; set; }
public string? BodyE { get; set; }
public string? Source { get; set; }
public string? SourceE { get; set; }
public string? Hotnews { get; set; }
public DateTime? PublishDate { get; set; }
public string? Show { get; set; }
public DateTime? ModifiedOn { get; set; }
public string? ModifiedBy { get; set; }
public int? Category_ID { get; set; }
public string? WorkFlow_ID { get; set; }
public string? State_ID { get; set; }
public string? ImageSave { get; set; }
public string? VerHor { get; set; }
public bool? Enable { get; set; }

        public WEB_NEWS()
        {
        }
    }
}


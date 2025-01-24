namespace Data_eHospital_DongNai_A.Model
{
    public partial class WEB_NEWS_CATEGORIES : BaseModel
    {
        [Key]
        public int? Category_ID { get; set; }
public string? Category_Name { get; set; }
public string? Category_NameE { get; set; }
public int? Index { get; set; }
public bool? Enable { get; set; }

        public WEB_NEWS_CATEGORIES()
        {
        }
    }
}


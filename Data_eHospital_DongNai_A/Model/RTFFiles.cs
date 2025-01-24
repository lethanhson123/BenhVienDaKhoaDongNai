namespace Data_eHospital_DongNai_A.Model
{
    public partial class RTFFiles : BaseModel
    {
        [Key]
        public int? FileID { get; set; }
public string? RTFFileText { get; set; }
public string? HTMLFileText { get; set; }

        public RTFFiles()
        {
        }
    }
}


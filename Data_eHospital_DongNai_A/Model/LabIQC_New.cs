namespace Data_eHospital_DongNai_A.Model
{
    public partial class LabIQC_New : BaseModel
    {
        [Key]
        public int? IQC_New_ID { get; set; }
public string? IQCName { get; set; }
public int? IQC_Level { get; set; }
public float? SD2_New_m { get; set; }
public float? SD2_New { get; set; }
public float? SD_New { get; set; }
public float? Mean_New { get; set; }
public float? CV_REF { get; set; }
public DateTime? FromDate { get; set; }
public DateTime? ToDate { get; set; }
public bool? IsActive { get; set; }
public DateTime? CreatedDate { get; set; }
public int? CreatedBy { get; set; }
public DateTime? ModifiedDate { get; set; }
public int? ModifiedBy { get; set; }
public int? ServiceID { get; set; }
public int? Lot_Id { get; set; }

        public LabIQC_New()
        {
        }
    }
}


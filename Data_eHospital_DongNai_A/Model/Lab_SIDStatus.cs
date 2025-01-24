namespace Data_eHospital_DongNai_A.Model
{
    public partial class Lab_SIDStatus : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? LabBarCodeID { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? CLSYeuCauChiTiet_Id { get; set; }
public int? ServiceID { get; set; }
public string? SIDIssueDate { get; set; }
public int? SamplePlaceID { get; set; }
public string? SamplePlace { get; set; }
public int? Status { get; set; }

        public Lab_SIDStatus()
        {
        }
    }
}


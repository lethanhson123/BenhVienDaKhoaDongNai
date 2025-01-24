namespace Data_eHospital_DongNai_A.Model
{
    public partial class VienPhiNoiTru_Loai_IDRef : BaseModel
    {
        [Key]
        public string? Loai_IDRef { get; set; }
public string? Loai_IDRef_Name { get; set; }
public string? TableName { get; set; }
public string? PhanNhom { get; set; }
public string? TenPhanNhom { get; set; }

        public VienPhiNoiTru_Loai_IDRef()
        {
        }
    }
}


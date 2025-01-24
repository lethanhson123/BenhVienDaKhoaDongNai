namespace Data_eHospital_DongNai_A.Model
{
    public partial class Cus_DoiTac : BaseModel
    {
        [Key]
        public int? DoiTac_id { get; set; }
public string? TenDoiTac { get; set; }
public int? Nhom { get; set; }
public bool? XuatRong { get; set; }
public bool? TamNgung { get; set; }

        public Cus_DoiTac()
        {
        }
    }
}


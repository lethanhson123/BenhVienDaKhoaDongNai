namespace Data_eHospital_DongNai_A.Model
{
    public partial class Cus_DM_NhaThuoc : BaseModel
    {
        [Key]
        public int? NhaThuoc_id { get; set; }
public string? TenNhaThuoc { get; set; }
public int? KhoDuoc_id { get; set; }
public string? Khu { get; set; }
public bool? TamNgung { get; set; }

        public Cus_DM_NhaThuoc()
        {
        }
    }
}


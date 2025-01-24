namespace Data_eHospital_DongNai_A.Model
{
    public partial class Cus_NoiXuat : BaseModel
    {
        [Key]
        public int? ViTri_id { get; set; }
public string? TenViTri { get; set; }
public string? Loai { get; set; }
public string? Khu { get; set; }
public int? KhoDuoc_id { get; set; }
public bool? TamNgung { get; set; }

        public Cus_NoiXuat()
        {
        }
    }
}


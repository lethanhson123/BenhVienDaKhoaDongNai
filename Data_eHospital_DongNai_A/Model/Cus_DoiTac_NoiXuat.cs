namespace Data_eHospital_DongNai_A.Model
{
    public partial class Cus_DoiTac_NoiXuat : BaseModel
    {
        [Key]
        public int? DoiTac_NoiXuat_id { get; set; }
public int? DoiTac_id { get; set; }
public int? ViTri_id { get; set; }
public string? DS_Duoc_id { get; set; }
public bool? TamNgung { get; set; }

        public Cus_DoiTac_NoiXuat()
        {
        }
    }
}


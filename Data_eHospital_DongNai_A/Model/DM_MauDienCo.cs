namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_MauDienCo : BaseModel
    {
        [Key]
        public int? MauDienCo_Id { get; set; }
public string? MaMauDienCo { get; set; }
public string? TenMauDienCo { get; set; }
public bool? TamNgung { get; set; }
public string? TemplateFileName { get; set; }
public string? MaNhomDichVu { get; set; }
public int? Hinh_Width { get; set; }
public int? Hinh_Height { get; set; }

        public DM_MauDienCo()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_MauBenh : BaseModel
    {
        [Key]
        public int? MauBenh_Id { get; set; }
public string? MaMauBenh { get; set; }
public string? TenMauBenh { get; set; }
public string? TenKhongDau { get; set; }
public bool? TamNgung { get; set; }

        public DM_MauBenh()
        {
        }
    }
}


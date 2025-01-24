namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_MauBenh_Column : BaseModel
    {
        [Key]
        public int? MauBenh_Column_Id { get; set; }
public int? MauBenh_Id { get; set; }
public string? TenColumn { get; set; }
public string? TenCot_KetQuaMauBenh { get; set; }
public string? KieuDuLieu { get; set; }
public bool? TamNgung { get; set; }
public string? Ma_MauBenh_Column { get; set; }
public int? WidthColumn { get; set; }
public int? Pos { get; set; }

        public DM_MauBenh_Column()
        {
        }
    }
}


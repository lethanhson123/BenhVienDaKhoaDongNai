namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_DoTuoiCDT : BaseModel
    {
        [Key]
        public int? DoTuoi_Id { get; set; }
public string? MaDoTuoi { get; set; }
public string? TenDoTuoi { get; set; }
public bool? TamNgung { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DM_DoTuoiCDT()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_TAIKHOAN : BaseModel
    {
        [Key]
        public string? SoTaiKhoan { get; set; }
public string? TenTaiKhoan { get; set; }
public string? Cap { get; set; }
public string? CapTren { get; set; }
public bool? InPut { get; set; }
public bool? CongNo { get; set; }
public string? DangSuDung { get; set; }
public bool? TKTrungGian { get; set; }
public string? Module { get; set; }
public string? LoaiTien { get; set; }
public string? PostModule { get; set; }

        public DM_TAIKHOAN()
        {
        }
    }
}


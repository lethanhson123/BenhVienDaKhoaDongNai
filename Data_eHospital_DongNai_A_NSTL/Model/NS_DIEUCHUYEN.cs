namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DIEUCHUYEN : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaNhanVien { get; set; }
public DateTime? NgayDieuChuyen { get; set; }
public DateTime? Ngayhieuluc { get; set; }
public string? MaPhongBanCu { get; set; }
public string? MaChucVuCu { get; set; }
public string? MaPhongBanMoi { get; set; }
public string? MaChucVuMoi { get; set; }

        public NS_DIEUCHUYEN()
        {
        }
    }
}


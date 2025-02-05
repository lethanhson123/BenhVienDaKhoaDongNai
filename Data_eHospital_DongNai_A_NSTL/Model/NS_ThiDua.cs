namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_ThiDua : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaNhanVien { get; set; }
public int? Nam { get; set; }
public int? TongDiem { get; set; }
public string? KhongDat { get; set; }
public string? KhongXet { get; set; }
public int? MucI { get; set; }
public int? MucII { get; set; }
public int? MucIII { get; set; }
public int? MucIV { get; set; }
public int? MucV { get; set; }
public int? MucVI { get; set; }
public int? MucVII { get; set; }
public int? MucVIII { get; set; }
public int? MucIX { get; set; }
public int? MucX { get; set; }
public int? MucXI { get; set; }
public int? MucXII { get; set; }
public int? MucXIII { get; set; }
public int? MucXIV { get; set; }
public int? MucXV { get; set; }
public int? MucXVI { get; set; }
public string? GhiChu { get; set; }
public string? ThiDuaDangKyDauNam { get; set; }
public string? KhoaPhongBau { get; set; }
public string? HDThiDuaXetDuyet { get; set; }

        public NS_ThiDua()
        {
        }
    }
}


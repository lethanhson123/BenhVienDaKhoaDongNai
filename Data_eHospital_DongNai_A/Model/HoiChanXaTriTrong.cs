namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoiChanXaTriTrong : BaseModel
    {
        [Key]
        public int? HoiChanXaTriTrong_Id { get; set; }
public string? SoPhieu { get; set; }
public int? BacSiChuNhiem_Id { get; set; }
public int? BacSi_Id { get; set; }
public int? KiThuatVienGMHS_Id { get; set; }
public int? BenhAn_Id { get; set; }
public string? KPS { get; set; }
public string? CanNang { get; set; }
public string? HuyetAp { get; set; }
public string? Mach { get; set; }
public string? NhietDo { get; set; }
public string? XQuangPhoi { get; set; }
public string? XQuangKhac { get; set; }
public string? SieuAm { get; set; }
public string? CTMRI { get; set; }
public string? NoiSoi { get; set; }
public string? DienTamDo { get; set; }
public string? NhomMau { get; set; }
public string? DungTichHongCau { get; set; }
public string? BachCau { get; set; }
public string? HuyetSacTo { get; set; }
public string? HongCau { get; set; }
public string? TieuCau { get; set; }
public string? UreHuyet { get; set; }
public string? Creatinin { get; set; }
public string? ProteinToanPhan { get; set; }
public string? DuongHuyet { get; set; }
public string? HBsAg { get; set; }
public string? HIV { get; set; }
public string? VDRLBW { get; set; }
public string? HuyetHoc { get; set; }
public string? SinhHoa { get; set; }
public string? ChucNangGan { get; set; }
public string? NuocTieu { get; set; }
public string? XetNghiemKhac { get; set; }
public string? DauHieuSinhHocBuou { get; set; }
public string? GPBL { get; set; }
public string? ChanDoan { get; set; }
public string? LieuPhapXaTriTrong { get; set; }
public string? LieuLuong { get; set; }
public string? ThoiGian { get; set; }
public int? BacSiThucHien_Id { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayTao { get; set; }

        public HoiChanXaTriTrong()
        {
        }
    }
}


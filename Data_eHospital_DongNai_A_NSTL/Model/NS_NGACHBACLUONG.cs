namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_NGACHBACLUONG : BaseModel
    {
        [Key]
        public string? MaNhanVien { get; set; }
public DateTime? Ngayxep { get; set; }
public string? MaNgach { get; set; }
public string? Ngach { get; set; }
public int? Bac { get; set; }
public float? HeSo { get; set; }
public float? PhuCap { get; set; }
public float? MucHuong { get; set; }
public int? LoaiHeSo { get; set; }
public int? id { get; set; }
public DateTime? NgayNangLuong { get; set; }
public string? SoQuyetDinh { get; set; }
public DateTime? NgayQuyetDinh { get; set; }
public float? PhuCapTNVK { get; set; }
public float? PhuCapTNVK_Moi { get; set; }
public float? HeSoQD276 { get; set; }
public float? HeSoDocHai { get; set; }
public float? UuDaiNghe { get; set; }
public string? TGNangLuongSom { get; set; }
public string? TGKeoDai { get; set; }
public int? SoThangTapSu { get; set; }
public float? HeSoLuongChinh { get; set; }
public float? HeSoKhuyenKhich { get; set; }
public float? HeSoKiemNhiem { get; set; }
public float? HeSoUuDaiTTUT { get; set; }
public float? HeSoK { get; set; }
public DateTime? NgayHuongBV { get; set; }
public float? HienVatMuc { get; set; }
public string? MaMucHuongDocHai { get; set; }
public float? HeSoTTND { get; set; }
public float? HeSoThamNien { get; set; }

        public NS_NGACHBACLUONG()
        {
        }
    }
}


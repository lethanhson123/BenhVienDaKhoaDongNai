namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_PhongBan : BaseModel
    {
        [Key]
        public int? PhongBan_Id { get; set; }
public string? MaPhongBan { get; set; }
public string? TenPhongBan { get; set; }
public string? TenPhongBan_En { get; set; }
public string? TenPhongBan_Ru { get; set; }
public int? LoaiPhongBan_Id { get; set; }
public int? Cap { get; set; }
public int? CapTren_Id { get; set; }
public string? TruongPhong { get; set; }
public int? LoaiPhongBenh_Id { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public bool? CoThucHienDichVu { get; set; }
public int? Idx { get; set; }
public bool? QuanLyNhanSu { get; set; }
public bool? IsKhoaDieuTri { get; set; }
public bool? IsChuyenKhoa { get; set; }
public int? CostCenTer_Id { get; set; }
public int? ChuyenKhoa_Id { get; set; }
public int? DiaDiemLamViec_Id { get; set; }
public string? SiteCode { get; set; }
public int? Mapping_Public_Id { get; set; }
public string? MaTheoQuiDinh { get; set; }
public int? SoThuTuMin { get; set; }
public int? SoThuTuMax { get; set; }
public int? SoThuTuMin_2 { get; set; }
public int? SoThuTuMax_2 { get; set; }

        public DM_PhongBan()
        {
        }
    }
}


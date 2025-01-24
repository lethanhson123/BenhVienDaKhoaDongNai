namespace Data_eHospital_DongNai_A.Model
{
    public partial class Duoc_DuTruChiTiet : BaseModel
    {
        [Key]
        public int? DuTruChiTiet_Id { get; set; }
public int? DuTru_Id { get; set; }
public int? Duoc_Id { get; set; }
public int? DonViTinh_Id { get; set; }
public int? NhaCungCap_Id { get; set; }
public string? HeSoNhanHang { get; set; }
public string? SoLuongTon { get; set; }
public string? SLHangCho { get; set; }
public string? UuTien { get; set; }
public string? SLXuat1 { get; set; }
public string? SLXuat2 { get; set; }
public string? SLXuat3 { get; set; }
public string? SLXuat4 { get; set; }
public string? SLTrungBinhXuat { get; set; }
public string? SLLyThuyet { get; set; }
public string? SLDongGoi { get; set; }
public string? SLTron { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public string? DonGia { get; set; }
public string? NguyenTe { get; set; }
public string? ThanhTien { get; set; }
public bool? DaPhatSinhPhieuDatHang { get; set; }
public string? GhiChuChiTiet { get; set; }

        public Duoc_DuTruChiTiet()
        {
        }
    }
}


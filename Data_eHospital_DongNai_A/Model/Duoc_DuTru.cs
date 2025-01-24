namespace Data_eHospital_DongNai_A.Model
{
    public partial class Duoc_DuTru : BaseModel
    {
        [Key]
        public int? DuTru_Id { get; set; }
public string? MaChungTu { get; set; }
public string? SoChungTu { get; set; }
public DateTime? NgayChungTu { get; set; }
public DateTime? NgayBaoCao { get; set; }
public int? MucDichChungTu_Id { get; set; }
public int? KhoNhap_Id { get; set; }
public int? NguoiNhan_Id { get; set; }
public string? NguoiNhan { get; set; }
public string? LoaiVatTu_Id { get; set; }
public int? NhomLoaiDuoc_Id { get; set; }
public bool? TonKhoDauKy { get; set; }
public DateTime? TongHop_TuNgay { get; set; }
public DateTime? TongHop_DenNgay { get; set; }
public string? DienGiai { get; set; }
public string? GiaTri { get; set; }
public string? GiaTriThanhToan { get; set; }
public string? TyLeVat { get; set; }
public string? GiaTriVat { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public int? NhaCungCap_Id { get; set; }
public int? DonViGiao_Id { get; set; }
public int? NguonDuoc_Id { get; set; }
public int? ChungTuLienQuan_Id { get; set; }
public int? NguoiNhap_Id { get; set; }
public DateTime? NgayNhap { get; set; }
public string? TrangThai { get; set; }
public string? DienGiaiNghiepVuPhatSinh { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public Duoc_DuTru()
        {
        }
    }
}


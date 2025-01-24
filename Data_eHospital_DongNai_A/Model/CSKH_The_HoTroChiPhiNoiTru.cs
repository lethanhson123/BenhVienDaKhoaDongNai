namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_The_HoTroChiPhiNoiTru : BaseModel
    {
        [Key]
        public int? The_HoTroChiPhiNoiTru_Id { get; set; }
public int? The_Id { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public decimal? SoTienToiDa { get; set; }
public decimal? SoTienNamVien { get; set; }
public int? SoNgayNamVien { get; set; }
public bool? Phong { get; set; }
public bool? Thuoc { get; set; }
public bool? XetNghiem { get; set; }
public bool? DieuTriTrongNgay { get; set; }
public decimal? SoTienPhauThuat { get; set; }
public int? SoNgayPhauThuat { get; set; }
public bool? PhauThuat { get; set; }
public bool? VatTuTieuHao { get; set; }
public bool? GayMe { get; set; }
public bool? KhamTruocPT { get; set; }
public bool? HoiSucSauPT { get; set; }
public DateTime? ThoiGianMin { get; set; }
public DateTime? ThoiGianMax { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? Attributes_1 { get; set; }
public int? Attributes_2 { get; set; }
public decimal? Attributes_3 { get; set; }
public decimal? Attributes_4 { get; set; }
public DateTime? Attributes_5 { get; set; }
public DateTime? Attributes_6 { get; set; }
public bool? Attributes_7 { get; set; }
public bool? Attributes_8 { get; set; }

        public CSKH_The_HoTroChiPhiNoiTru()
        {
        }
    }
}


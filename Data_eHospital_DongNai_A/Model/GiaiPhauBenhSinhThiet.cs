namespace Data_eHospital_DongNai_A.Model
{
    public partial class GiaiPhauBenhSinhThiet : BaseModel
    {
        [Key]
        public int? GiaiPhauBenhSinhThiet_Id { get; set; }
public string? SoPhieu { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? BacSiDieuTri_Id { get; set; }
public string? TruongHopGiaiPhauBenh { get; set; }
public string? SinhThietDuocLayTu { get; set; }
public string? CoDinhBangDungDich { get; set; }
public DateTime? Luc { get; set; }
public string? TomTatDauHieuLSXN { get; set; }
public string? QuaTrinhDieuTri { get; set; }
public string? NhanXetDaiTheKhiLayST { get; set; }
public string? KetQuaSinhThietLanTruoc { get; set; }
public string? ChanDoanLamSang { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCoDinh_Id { get; set; }

        public GiaiPhauBenhSinhThiet()
        {
        }
    }
}


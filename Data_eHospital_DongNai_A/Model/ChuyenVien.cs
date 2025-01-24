namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChuyenVien : BaseModel
    {
        [Key]
        public int? ChuyenVien_Id { get; set; }
public string? SoPhieu { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? BenhAnNoiTru_Id { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }
public int? BacSiYeuCau_Id { get; set; }
public int? BacSiTruongKhoa_Id { get; set; }
public int? BenhVien_Id { get; set; }
public int? LyDoChuyenVien_Id { get; set; }
public int? ChanDoanICD_Id { get; set; }
public string? ChanDoan { get; set; }
public DateTime? NgayChuyen { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? DauHieuLamSang { get; set; }
public string? TinhTrang { get; set; }
public string? NguoiDuaDi { get; set; }
public string? PhuongTien { get; set; }
public bool? ChuyenVienBangGiayKhaiSinh { get; set; }
public string? ThuocDaDung { get; set; }
public int? HinhThucChuyenVien_Id { get; set; }
public string? HuongDieuTri { get; set; }
public int? TiepNhan_NoiGioiThieu_ID { get; set; }
public string? TiepNhan_SoChuyenTuyen { get; set; }
public DateTime? TiepNhan_NgayChuyenDen { get; set; }
public int? TiepNhan_TuyenChuyen_ID { get; set; }
public int? TiepNhan_LyDoChuyenDen_ID { get; set; }
public string? TiepNhan_ChanDoan_NGT { get; set; }
public int? PhuongTien_ID { get; set; }

        public ChuyenVien()
        {
        }
    }
}


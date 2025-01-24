namespace Data_eHospital_DongNai_A.Model
{
    public partial class KiemDiemTuVong : BaseModel
    {
        [Key]
        public int? KiemDiemTuVong_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? KhoaKiemDiem_Id { get; set; }
public DateTime? NgayKiemDiem { get; set; }
public DateTime? ThoiGianKiemDiem { get; set; }
public string? NguoiLienHe { get; set; }
public string? DienThoai { get; set; }
public DateTime? ThoiGianTuVong { get; set; }
public int? KhoaTuVong_Id { get; set; }
public int? NguyenNhan_Id { get; set; }
public string? NguyenNhan { get; set; }
public int? ICD_TuVong { get; set; }
public string? TienSu { get; set; }
public string? TinhTrangVaoVien { get; set; }
public string? ChanDoan { get; set; }
public int? ICD_ChanDoan { get; set; }
public string? DienBien { get; set; }
public string? TiepDonBenh { get; set; }
public string? ThamKham { get; set; }
public string? DieuTri { get; set; }
public string? ChamSoc { get; set; }
public string? QuanHeVoiGiaDinhBenhNhan { get; set; }
public string? YKienBoSung { get; set; }
public string? KetLuan { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? KhoaDieuTri_Id { get; set; }

        public KiemDiemTuVong()
        {
        }
    }
}


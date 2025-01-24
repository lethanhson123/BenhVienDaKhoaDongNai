namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamBenh_ChuyenKhoa : BaseModel
    {
        [Key]
        public int? KhamBenh_ChuyenKhoa_Id { get; set; }
public int? PhongBan_Id { get; set; }
public int? DichVu_Id { get; set; }
public DateTime? NgayChiDinh { get; set; }
public DateTime? ThoiGianChiDinh { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? KhamBenhChuyenDi_Id { get; set; }
public int? KhamBenhDauTien_Id { get; set; }
public int? LichHen_BenhNhan_Id { get; set; }
public bool? DuocPhepThucHien { get; set; }
public int? YeuCauChiTiet_Id { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public KhamBenh_ChuyenKhoa()
        {
        }
    }
}


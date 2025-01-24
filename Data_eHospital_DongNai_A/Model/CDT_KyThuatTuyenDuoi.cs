namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_KyThuatTuyenDuoi : BaseModel
    {
        [Key]
        public int? CDT_KyThuatTuyenDuoi_Id { get; set; }
public int? KyThuat_Id { get; set; }
public int? BenhVien_Id { get; set; }
public int? TrangThai_Id { get; set; }
public DateTime? NgayQuanLy { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? NhanVienTuyenDuoi_Id { get; set; }
public string? GhiChu { get; set; }
public string? TenBenhNhan { get; set; }
public int? NamSinh { get; set; }
public string? GioiTinh { get; set; }
public int? ChanDoanICD_Id { get; set; }
public string? ChanDoan { get; set; }
public int? BacSiPT_Id { get; set; }
public int? BacSiPT2_Id { get; set; }
public int? BacSiPT3_Id { get; set; }
public int? BacSiGM_Id { get; set; }
public int? BacSiGM2_Id { get; set; }
public int? DieuDuongPV_Id { get; set; }
public int? DieuDuongPV1_Id { get; set; }
public int? DieuDuongPV2_Id { get; set; }
public int? DieuDuongPV3_Id { get; set; }
public int? DieuDuongPV4_Id { get; set; }

        public CDT_KyThuatTuyenDuoi()
        {
        }
    }
}


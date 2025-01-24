namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamBenh_TiemChung : BaseModel
    {
        [Key]
        public int? KhamBenh_TiemChung_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? Duoc_Id { get; set; }
public string? LoSuDung { get; set; }
public DateTime? HanSuDung { get; set; }
public DateTime? NgaySuDung { get; set; }
public int? NoiDungTiemNgua_Id { get; set; }
public int? LanTiem { get; set; }
public decimal? NhietDoBatDauTiem { get; set; }
public decimal? NhietDoHetBuoiTiem { get; set; }
public int? NguoiTiem_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? BacSi_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? YeuCauChiTiet_Id { get; set; }

        public KhamBenh_TiemChung()
        {
        }
    }
}


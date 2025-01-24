namespace Data_eHospital_DongNai_A.Model
{
    public partial class LichLamViecChiTiet : BaseModel
    {
        [Key]
        public int? LichLamViecChiTiet_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? PhongBan_Id { get; set; }
public DateTime? Ngay { get; set; }
public DateTime? ThoiGianBatDau { get; set; }
public DateTime? ThoiGianKetThuc { get; set; }
public int? Schedule_id { get; set; }
public int? ScheduleDetail_Id { get; set; }
public bool? Huy { get; set; }
public bool? TamNgung { get; set; }
public int? NguoiTao_Id { get; set; }
public int? NguoiCapNhat { get; set; }
public DateTime? NgayTao { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NhanVienTao_id { get; set; }
public int? NhanVienCapNhat_id { get; set; }
public string? LyDoCapNhat { get; set; }
public string? GhiChu { get; set; }
public int? Schedule_Type_Id { get; set; }
public int? Block { get; set; }
public int? PrecentOfBlock { get; set; }
public bool? isHoliday { get; set; }
public int? Holiday_Id { get; set; }

        public LichLamViecChiTiet()
        {
        }
    }
}


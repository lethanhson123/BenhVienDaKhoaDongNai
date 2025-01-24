namespace Data_eHospital_DongNai_A.Model
{
    public partial class PhieuMoPhong : BaseModel
    {
        [Key]
        public int? PhieuMoPhong_ID { get; set; }
public string? SoPhieu { get; set; }
public int? CLSYeuCau_ID { get; set; }
public int? CLSYeuCauChiTiet_ID { get; set; }
public int? BenhNhan_ID { get; set; }
public int? TiepNhan_ID { get; set; }
public int? BenhAn_ID { get; set; }
public int? KhoaGoiDen_ID { get; set; }
public string? ChanDoanGiaiDoan { get; set; }
public string? ChuanBiTruoc { get; set; }
public int? NguoiTao_ID { get; set; }
public DateTime? ThoiGianTao { get; set; }
public int? NguoiCapNhat_ID { get; set; }
public DateTime? ThoiGianCapNhat { get; set; }
public int? LoaiMoPhong { get; set; }
public DateTime? ThoiGianMoPhong { get; set; }
public DateTime? NgayMoPhong { get; set; }
public int? BacSi_ID { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public PhieuMoPhong()
        {
        }
    }
}


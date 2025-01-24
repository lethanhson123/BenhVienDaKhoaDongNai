namespace Data_eHospital_DongNai_A.Model
{
    public partial class XepLichMo : BaseModel
    {
        [Key]
        public int? LichMo_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? CLSYeuCauChiTiet_Id { get; set; }
public DateTime? NgayMo { get; set; }
public DateTime? ThoiGianMo { get; set; }
public string? ChanDoanVaPhauThuat { get; set; }
public DateTime? NgayTao { get; set; }
public int? BacSi01_Id { get; set; }
public int? BacSi02_Id { get; set; }
public int? BacSi03_Id { get; set; }
public int? BacSi04_Id { get; set; }
public string? MauDuTru { get; set; }
public int? PPVoCam_Id { get; set; }
public int? PhongBan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public DateTime? ThoiGianketThuc { get; set; }

        public XepLichMo()
        {
        }
    }
}


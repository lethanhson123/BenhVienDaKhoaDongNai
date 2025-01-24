namespace Data_eHospital_DongNai_A.Model
{
    public partial class XacNhanChiPhiBHTN : BaseModel
    {
        [Key]
        public int? XacNhanChiPhi_Id { get; set; }
public string? SoXacNhan { get; set; }
public DateTime? NgayXacNhan { get; set; }
public int? NoiXacNhan_ID { get; set; }
public string? Loai { get; set; }
public int? GhiNhan_Id { get; set; }
public string? SoPhieuGhiNhan { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? CongTy_ID { get; set; }
public string? SoTheBHTN { get; set; }
public decimal? GiaTri { get; set; }
public string? GhiChu { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public DateTime? ThoiGianLap { get; set; }

        public XacNhanChiPhiBHTN()
        {
        }
    }
}


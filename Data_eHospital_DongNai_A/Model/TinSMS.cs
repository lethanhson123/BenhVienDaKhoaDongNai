namespace Data_eHospital_DongNai_A.Model
{
    public partial class TinSMS : BaseModel
    {
        [Key]
        public int? TinSMS_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public string? SoDienThoai { get; set; }
public string? NoiDungSMS { get; set; }
public DateTime? ThoiGianTuDongGui { get; set; }
public int? MauTin_Id { get; set; }
public bool? DaGui { get; set; }
public DateTime? ThoiGianGui { get; set; }
public int? NguoiGui_Id { get; set; }
public string? TinSMS_LoaiTinId { get; set; }
public int? ThongTinId { get; set; }
public DateTime? ThoiGianCapNhat { get; set; }
public string? SMSGUID { get; set; }

        public TinSMS()
        {
        }
    }
}


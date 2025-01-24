namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnTongQuat : BaseModel
    {
        [Key]
        public int? BenhAnTongQuat_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? BenhAnTongQuatLienQuan_Id { get; set; }
public string? SoBenhAn { get; set; }
public string? SoLuuTru { get; set; }
public int? LoaiBenhAn_Id { get; set; }
public DateTime? NgayLap { get; set; }
public DateTime? ThoiGianLap { get; set; }
public int? NoiLap_Id { get; set; }
public int? NguoiLap_Id { get; set; }
public bool? KhoaBenhAn { get; set; }
public string? TrangThai { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public BenhAnTongQuat()
        {
        }
    }
}


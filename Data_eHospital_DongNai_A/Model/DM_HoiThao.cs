namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_HoiThao : BaseModel
    {
        [Key]
        public int? HoiThao_Id { get; set; }
public string? MaHoiThao { get; set; }
public string? TenHoiThao { get; set; }
public DateTime? NgayBatDau { get; set; }
public DateTime? NgayKetThuc { get; set; }
public string? DiaDiem { get; set; }
public string? KetQua { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DM_HoiThao()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_KeHoachDeAn_1816 : BaseModel
    {
        [Key]
        public int? KeHoach_Id { get; set; }
public string? MaCongViec { get; set; }
public string? TenCongViec { get; set; }
public string? NoiDung { get; set; }
public string? DiaDiem { get; set; }
public string? HinhThuc { get; set; }
public DateTime? NgayBatDau { get; set; }
public DateTime? NgayKetThuc { get; set; }
public string? KetQua { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DM_KeHoachDeAn_1816()
        {
        }
    }
}


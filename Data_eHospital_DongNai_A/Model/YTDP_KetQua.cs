namespace Data_eHospital_DongNai_A.Model
{
    public partial class YTDP_KetQua : BaseModel
    {
        [Key]
        public int? KetQua_Id { get; set; }
public int? NoiKiemTra_Id { get; set; }
public string? NoiKiemTra { get; set; }
public DateTime? TuNgay { get; set; }
public DateTime? DenNgay { get; set; }
public int? BacSi_Id { get; set; }
public string? TenBacSi { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public YTDP_KetQua()
        {
        }
    }
}


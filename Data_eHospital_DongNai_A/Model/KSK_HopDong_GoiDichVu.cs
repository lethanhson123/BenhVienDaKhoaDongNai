namespace Data_eHospital_DongNai_A.Model
{
    public partial class KSK_HopDong_GoiDichVu : BaseModel
    {
        [Key]
        public int? KSK_HopDong_GoiDichVu_Id { get; set; }
public int? HopDong_Id { get; set; }
public string? GoiDichVu_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public decimal? Attribute1 { get; set; }
public decimal? Attribute2 { get; set; }
public int? Attribute3 { get; set; }
public string? Attribute4 { get; set; }
public DateTime? Attribute5 { get; set; }
public bool? Attribute6 { get; set; }

        public KSK_HopDong_GoiDichVu()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class Duoc_DonGiaVon : BaseModel
    {
        [Key]
        public int? Duoc_DonGiaVon_ID { get; set; }
public int? DuocKyTonKho_ID { get; set; }
public int? Duoc_ID { get; set; }
public string? DonGiaVon { get; set; }
public bool? Khoa { get; set; }
public string? DienGiai { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public Duoc_DonGiaVon()
        {
        }
    }
}


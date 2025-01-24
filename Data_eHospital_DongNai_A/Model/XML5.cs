namespace Data_eHospital_DongNai_A.Model
{
    public partial class XML5 : BaseModel
    {
        [Key]
        public int? XML5_id { get; set; }
public string? LoaiKCB { get; set; }
public int? IdMaLienKet { get; set; }
public string? Loai_DienBien { get; set; }
public int? IDRef { get; set; }
public string? DIEN_BIEN { get; set; }
public string? HOI_CHAN { get; set; }
public string? PHAU_THUAT { get; set; }
public DateTime? NGAY_YL { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat { get; set; }

        public XML5()
        {
        }
    }
}


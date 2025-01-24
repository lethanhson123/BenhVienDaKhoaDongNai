namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoSoLienThongSoYTe : BaseModel
    {
        [Key]
        public int? GiaoDich_Id { get; set; }
public string? MaGiaoDich { get; set; }
public string? FileXML { get; set; }
public string? Messenger { get; set; }
public DateTime? CreateDate { get; set; }
public int? SoHoSo { get; set; }
public DateTime? TimTuThoiGian { get; set; }
public DateTime? TimDenThoiGian { get; set; }
public string? PID { get; set; }
public string? isNoiNgoai { get; set; }
public int? TiepNhan_Id { get; set; }

        public HoSoLienThongSoYTe()
        {
        }
    }
}


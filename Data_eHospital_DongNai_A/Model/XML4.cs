namespace Data_eHospital_DongNai_A.Model
{
    public partial class XML4 : BaseModel
    {
        [Key]
        public int? XML4_id { get; set; }
public string? LoaiKCB { get; set; }
public int? IdMaLienKet { get; set; }
public string? Loai_KQ { get; set; }
public int? IDRef { get; set; }
public string? MA_DICH_VU { get; set; }
public string? MA_CHI_SO { get; set; }
public string? TEN_CHI_SO { get; set; }
public string? GIA_TRI { get; set; }
public string? MA_MAY { get; set; }
public string? MO_TA { get; set; }
public string? KET_LUAN { get; set; }
public DateTime? NGAY_KQ { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat { get; set; }

        public XML4()
        {
        }
    }
}


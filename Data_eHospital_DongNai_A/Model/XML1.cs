namespace Data_eHospital_DongNai_A.Model
{
    public partial class XML1 : BaseModel
    {
        [Key]
        public int? XML1_id { get; set; }
public string? LoaiKCB { get; set; }
public int? IdMaLienKet { get; set; }
public string? MA_BN { get; set; }
public string? HO_TEN { get; set; }
public DateTime? NGAY_SINH { get; set; }
public int? GIOI_TINH { get; set; }
public string? DIA_CHI { get; set; }
public string? MA_THE { get; set; }
public string? MA_DKBD { get; set; }
public string? GT_THE_TU { get; set; }
public string? GT_THE_DEN { get; set; }
public string? TEN_BENH { get; set; }
public string? MA_BENH { get; set; }
public string? MA_BENHKHAC { get; set; }
public int? MA_LYDO_VVIEN { get; set; }
public string? MA_NOI_CHUYEN { get; set; }
public int? MA_TAI_NAN { get; set; }
public DateTime? NGAY_VAO { get; set; }
public DateTime? NGAY_RA { get; set; }
public DateTime? NGAY_VAO_NOI_TRU { get; set; }
public int? SO_NGAY_DTRI { get; set; }
public int? KET_QUA_DTRI { get; set; }
public int? TINH_TRANG_RV { get; set; }
public DateTime? NGAY_TTOAN { get; set; }
public DateTime? MIEN_CUNG_CT { get; set; }
public string? T_THUOC { get; set; }
public string? T_VTYT { get; set; }
public string? T_TONGCHI { get; set; }
public string? T_BHTT { get; set; }
public string? T_BNTT { get; set; }
public string? T_BNCCT { get; set; }
public string? T_NGUONKHAC { get; set; }
public string? T_NGOAIDS { get; set; }
public int? NAM_QT { get; set; }
public int? THANG_QT { get; set; }
public int? MA_LOAI_KCB { get; set; }
public string? MA_KHOA { get; set; }
public string? MA_CSKCB { get; set; }
public string? MA_KHUVUC { get; set; }
public string? MA_PTTT_QT { get; set; }
public string? CAN_NANG { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat { get; set; }

        public XML1()
        {
        }
    }
}


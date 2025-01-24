namespace Data_eHospital_DongNai_A.Model
{
    public partial class XML2 : BaseModel
    {
        [Key]
        public int? XML2_id { get; set; }
        public string? LoaiKCB { get; set; }
        public int? IdMaLienKet { get; set; }
        public string? Loai_IDRef { get; set; }
        public int? IDRef { get; set; }
        public string? MA_THUOC { get; set; }
        public int? MA_NHOM { get; set; }
        public string? TEN_THUOC { get; set; }
        public string? DON_VI_TINH { get; set; }
        public string? HAM_LUONG { get; set; }
        public string? DUONG_DUNG { get; set; }
        public string? LIEU_DUNG { get; set; }
        public string? SO_DANG_KY { get; set; }
        public string? SO_LUONG { get; set; }
        public string? DON_GIA { get; set; }
        public int? TYLE_TT { get; set; }
        public string? THANH_TIEN { get; set; }
        public string? TT_THAU { get; set; }
        public int? PHAM_VI { get; set; }
        public string? MUC_HUONG { get; set; }
        public string? T_BNTT { get; set; }
        public string? T_BHTT { get; set; }
        public string? T_BNCCT { get; set; }
        public string? T_NGUONKHAC { get; set; }
        public string? T_NGOAIDS { get; set; }
        public string? MA_KHOA { get; set; }
        public string? MA_BAC_SI { get; set; }
        public string? MA_BENH { get; set; }
        public DateTime? NGAY_YL { get; set; }
        public int? MA_PTTT { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? NguoiTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public int? NguoiCapNhat { get; set; }

        public XML2()
        {
        }
    }
}


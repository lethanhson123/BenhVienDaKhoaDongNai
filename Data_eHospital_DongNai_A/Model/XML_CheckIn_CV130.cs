namespace Data_eHospital_DongNai_A.Model
{
    public partial class XML_CheckIn_CV130 : BaseModel
    {
        [Key]
        public int? XML_CheckIn_CV130_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? XacNhanChiPhi_Id { get; set; }
public string? MA_LK { get; set; }
public int? STT { get; set; }
public string? MA_BN { get; set; }
public string? HO_TEN { get; set; }
public string? SO_CCCD { get; set; }
public string? NGAY_SINH { get; set; }
public int? GIOI_TINH { get; set; }
public string? MA_THE_BHYT { get; set; }
public string? MA_DKBD { get; set; }
public string? GT_THE_TU { get; set; }
public string? GT_THE_DEN { get; set; }
public int? MA_DOITUONG_KCB { get; set; }
public string? NGAY_VAO { get; set; }
public string? NGAY_VAO_NOI_TRU { get; set; }
public string? LY_DO_VNT { get; set; }
public string? MA_LY_DO_VNT { get; set; }
public string? MA_LOAI_KCB { get; set; }
public string? MA_CSKCB { get; set; }
public string? MA_DICH_VU { get; set; }
public string? TEN_DICH_VU { get; set; }
public string? NGAY_YL { get; set; }
public string? MA_THUOC { get; set; }
public string? TEN_THUOC { get; set; }
public string? MA_VAT_TU { get; set; }
public string? TEN_VAT_TU { get; set; }
public string? DU_PHONG { get; set; }
public bool? DaGui { get; set; }

        public XML_CheckIn_CV130()
        {
        }
    }
}


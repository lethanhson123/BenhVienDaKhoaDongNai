namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoiChanPhauThuat : BaseModel
    {
        [Key]
        public int? HoiChanPhauThuat_Id { get; set; }
public string? SoPhieuHoiChanPhauThuat { get; set; }
public int? BacSiChuNhiem_Id { get; set; }
public int? BacSiGMHS_Id { get; set; }
public int? BenhAn_Id { get; set; }
public string? KPS { get; set; }
public string? CanNang { get; set; }
public string? HuyetAp { get; set; }
public string? Mach { get; set; }
public string? NhietDo { get; set; }
public string? XQuangPhoi { get; set; }
public string? XQuangKhac { get; set; }
public string? SieuAm { get; set; }
public string? CTMRI { get; set; }
public string? NoiSoi { get; set; }
public string? DienTamDo { get; set; }
public string? NhomMau { get; set; }
public string? DungTichHongCau { get; set; }
public string? BachCau { get; set; }
public string? HongCau { get; set; }
public string? HuyetSacTo { get; set; }
public string? TieuCau { get; set; }
public string? MauChay { get; set; }
public string? MauLang { get; set; }
public string? MauDong { get; set; }
public string? UreHuyet { get; set; }
public string? Creatinin { get; set; }
public string? DuongHuyet { get; set; }
public string? ProteinToanPhan { get; set; }
public string? Glucoza { get; set; }
public string? Protein { get; set; }
public string? CanLang { get; set; }
public decimal? TiTrong { get; set; }
public string? TQ { get; set; }
public string? TCK { get; set; }
public string? HBsAg { get; set; }
public string? HIV { get; set; }
public string? AntiHCV { get; set; }
public string? SGPT { get; set; }
public string? SGOT { get; set; }
public string? TiSoAg { get; set; }
public string? Prothrombin { get; set; }
public string? BilirubinTT { get; set; }
public string? BilirubinGT { get; set; }
public string? BilirubinTP { get; set; }
public string? DauHieuSinhHocBuou { get; set; }
public string? GPBLtruocMo { get; set; }
public string? ChanDoan { get; set; }
public string? TestPNC { get; set; }
public string? SM { get; set; }
public string? MauDuTru { get; set; }
public string? PhuongPhapVoCam { get; set; }
public string? PhuongPhapMo { get; set; }
public string? KipMo { get; set; }
public string? DungCuDacBiet { get; set; }
public DateTime? NgayMo { get; set; }
public int? KhoaNgoai_Id { get; set; }
public int? PhongMo_Id { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public HoiChanPhauThuat()
        {
        }
    }
}


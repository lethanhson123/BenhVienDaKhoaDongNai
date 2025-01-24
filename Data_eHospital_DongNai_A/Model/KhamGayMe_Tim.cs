namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamGayMe_Tim : BaseModel
    {
        [Key]
        public int? KhamGayMe_Tim_Id { get; set; }
public string? SoPhieuGayMe { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public DateTime? NgayThucHien { get; set; }
public DateTime? ThoiGianThuchien { get; set; }
public int? BacSiGayMe_Id { get; set; }
public decimal? ChieuCao { get; set; }
public decimal? CanNang { get; set; }
public string? K { get; set; }
public string? BH_HT { get; set; }
public string? PT { get; set; }
public string? Crea { get; set; }
public string? aPTT { get; set; }
public string? ChanDoan { get; set; }
public string? ChupMachVanh { get; set; }
public string? TimMach { get; set; }
public string? Phoi { get; set; }
public string? ThucQuan { get; set; }
public string? DaDay { get; set; }
public string? TaTrang { get; set; }
public string? ThanKinh { get; set; }
public string? TietNieu { get; set; }
public string? DaiDuong { get; set; }
public bool? ThuocLa { get; set; }
public bool? Ruou { get; set; }
public bool? MaTuy { get; set; }
public string? DiUng { get; set; }
public string? SAQuaNguc { get; set; }
public string? SAQuaThucQuan { get; set; }
public string? HepCanh { get; set; }
public string? ALĐMPsyst { get; set; }
public string? ASA { get; set; }
public string? NYHA { get; set; }
public string? DieuTriTruocMo { get; set; }
public string? Nghe { get; set; }
public string? XQPhoi { get; set; }
public string? TestAllenPhai { get; set; }
public string? TestAllenTrai { get; set; }
public string? DienTim { get; set; }
public string? TienMe { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? TieuCau { get; set; }

        public KhamGayMe_Tim()
        {
        }
    }
}


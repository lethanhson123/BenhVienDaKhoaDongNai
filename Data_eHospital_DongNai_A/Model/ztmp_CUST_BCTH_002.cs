namespace Data_eHospital_DongNai_A.Model
{
    public partial class ztmp_CUST_BCTH_002 : BaseModel
    {
        [Key]
        public int? STT { get; set; }
public string? MaYTe { get; set; }
public string? SoBenhAn { get; set; }
public string? TenBenhNhan { get; set; }
public int? NamSinh { get; set; }
public string? GioiTinh { get; set; }
public string? SoBHYT { get; set; }
public string? NoiDungThucHien { get; set; }
public decimal? SoLuong { get; set; }
public decimal? DonGia { get; set; }
public decimal? ThanhTien { get; set; }
public string? NguoiChiDinh { get; set; }

        public ztmp_CUST_BCTH_002()
        {
        }
    }
}


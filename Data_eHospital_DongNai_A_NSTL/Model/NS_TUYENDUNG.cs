namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_TUYENDUNG : BaseModel
    {
        [Key]
        public int? id { get; set; }
public string? MaUngVien { get; set; }
public string? NoidungthiPV { get; set; }
public string? Vongthi { get; set; }
public string? MaNhanVien { get; set; }
public DateTime? Ngaythi { get; set; }
public string? Nhanxet { get; set; }
public string? Ketqua { get; set; }

        public NS_TUYENDUNG()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_LICHTRUC : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaNhanVien { get; set; }
public DateTime? NgayTruc { get; set; }
public string? MaCaTruc { get; set; }
public string? NoiDungTruc { get; set; }
public string? MaPhongBan { get; set; }
public string? MaTrachNhiem { get; set; }
public string? LeChuNhat { get; set; }
public string? ViTri { get; set; }
public string? NhiemVu { get; set; }
public string? DaTruc { get; set; }

        public NS_LICHTRUC()
        {
        }
    }
}


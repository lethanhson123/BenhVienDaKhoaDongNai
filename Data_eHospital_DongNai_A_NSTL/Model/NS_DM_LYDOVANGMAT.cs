namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_LYDOVANGMAT : BaseModel
    {
        [Key]
        public string? MaLyDoVangMat { get; set; }
public string? TenLyDoVangMat { get; set; }
public bool? TruPhep { get; set; }
public string? TenTat { get; set; }
public bool? CoHuongLuong { get; set; }
public bool? NghiDaiHan { get; set; }
public int? BHXHTra { get; set; }
public decimal? SoGio { get; set; }
public int? SoNgayNghiToiDa { get; set; }
public bool? Truc { get; set; }
public bool? CoPhep { get; set; }
public bool? LamThem { get; set; }

        public NS_DM_LYDOVANGMAT()
        {
        }
    }
}


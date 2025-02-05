namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_LoaiTruc_NgoaiGio : BaseModel
    {
        [Key]
        public int? LoaiTruc_Id { get; set; }
public string? MaLoaiTruc { get; set; }
public string? TenLoaiTruc { get; set; }
public string? GhiChu { get; set; }
public bool? TamNgung { get; set; }

        public NS_DM_LoaiTruc_NgoaiGio()
        {
        }
    }
}


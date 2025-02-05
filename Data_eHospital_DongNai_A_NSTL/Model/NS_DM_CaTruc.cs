namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_CaTruc : BaseModel
    {
        [Key]
        public int? CaTruc_Id { get; set; }
public string? TenCaTruc { get; set; }
public DateTime? ThoiGianBatDau { get; set; }
public DateTime? ThoiGianKetThuc { get; set; }
public string? GhiChu { get; set; }
public bool? TamNgung { get; set; }
public bool? Truc { get; set; }

        public NS_DM_CaTruc()
        {
        }
    }
}


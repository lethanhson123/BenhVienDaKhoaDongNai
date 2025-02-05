namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_TinhTrangQuanHe : BaseModel
    {
        [Key]
        public int? TinhTrangQuanHe_Id { get; set; }
public string? MaTinhTrang { get; set; }
public string? TenTinhTrang { get; set; }
public bool? TamNgung { get; set; }

        public NS_DM_TinhTrangQuanHe()
        {
        }
    }
}


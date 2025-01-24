namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_PhacDoDieuTriDichVu_CT : BaseModel
    {
        [Key]
        public int? PhacDoDTDVCT_Id { get; set; }
public int? PhacDoDT_Id { get; set; }
public int? DichVu_Id { get; set; }
public int? SoLuong { get; set; }
public int? ChuKy_Id { get; set; }
public string? GhiChu { get; set; }

        public DM_PhacDoDieuTriDichVu_CT()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_PhacDoDieuTri_CT : BaseModel
    {
        [Key]
        public int? PhacDoDTCT_Id { get; set; }
public int? PhacDoDT_Id { get; set; }
public int? Duoc_Id { get; set; }
public decimal? Sang { get; set; }
public decimal? Trua { get; set; }
public decimal? Chieu { get; set; }
public decimal? Toi { get; set; }
public decimal? SoLuong { get; set; }
public int? SoNgay { get; set; }
public int? DuongDung_Id { get; set; }
public int? ChuKy_Id { get; set; }
public string? GhiChu { get; set; }

        public DM_PhacDoDieuTri_CT()
        {
        }
    }
}


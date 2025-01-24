namespace Data_eHospital_DongNai_A.Model
{
    public partial class BHYT_Export_His : BaseModel
    {
        [Key]
        public int? Id_BHYT_His { get; set; }
public string? MaFile { get; set; }
public bool? IsDelete { get; set; }
public bool? IsUpdate { get; set; }
public DateTime? NgayXuat { get; set; }
public DateTime? NgayXoa { get; set; }
public DateTime? NgayUpdate { get; set; }

        public BHYT_Export_His()
        {
        }
    }
}


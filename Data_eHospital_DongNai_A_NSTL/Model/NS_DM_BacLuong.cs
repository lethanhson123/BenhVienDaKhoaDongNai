namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_BacLuong : BaseModel
    {
        [Key]
        public int? Id { get; set; }
public int? MaBac { get; set; }
public string? MaNgach { get; set; }
public decimal? HeSoHuong { get; set; }
public int? SoNamTangBac { get; set; }
public bool? KinhDoanh { get; set; }

        public NS_DM_BacLuong()
        {
        }
    }
}


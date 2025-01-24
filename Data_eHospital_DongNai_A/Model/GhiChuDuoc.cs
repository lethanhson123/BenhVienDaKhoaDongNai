namespace Data_eHospital_DongNai_A.Model
{
    public partial class GhiChuDuoc : BaseModel
    {
        [Key]
        public int? GhiChuDuoc_Id { get; set; }
public string? NoiDung { get; set; }
public int? BacSi_Id { get; set; }

        public GhiChuDuoc()
        {
        }
    }
}


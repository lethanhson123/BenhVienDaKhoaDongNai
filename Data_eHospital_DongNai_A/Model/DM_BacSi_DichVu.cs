namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_BacSi_DichVu : BaseModel
    {
        [Key]
        public int? BacSi_DichVu_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? DichVu_Id { get; set; }

        public DM_BacSi_DichVu()
        {
        }
    }
}


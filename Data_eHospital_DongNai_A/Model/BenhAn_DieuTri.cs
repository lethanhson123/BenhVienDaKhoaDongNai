namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAn_DieuTri : BaseModel
    {
        [Key]
        public int? BenhAn_DieuTri_Id { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }
public DateTime? NgayDieuTri { get; set; }
public int? BacSi_1 { get; set; }
public int? BacSi_2 { get; set; }
public string? NoiDung { get; set; }
public string? GhiChu { get; set; }

        public BenhAn_DieuTri()
        {
        }
    }
}


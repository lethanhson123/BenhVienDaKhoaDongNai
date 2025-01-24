namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAn_ChiTiet : BaseModel
    {
        [Key]
        public int? BenhAn_ChiTiet_Id { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }
public int? BoPhan_Id { get; set; }
public int? Value_Id { get; set; }
public string? ValueText { get; set; }

        public BenhAn_ChiTiet()
        {
        }
    }
}


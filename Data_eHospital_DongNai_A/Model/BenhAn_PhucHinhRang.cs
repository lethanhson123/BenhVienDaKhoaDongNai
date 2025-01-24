namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAn_PhucHinhRang : BaseModel
    {
        [Key]
        public int? BenhAn_PhucHinhRang_Id { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }
public int? TieuPhau_Id { get; set; }
public int? DieuTriRang_Id { get; set; }
public int? XQuang_Id { get; set; }
public string? HuongPhucHinh { get; set; }

        public BenhAn_PhucHinhRang()
        {
        }
    }
}


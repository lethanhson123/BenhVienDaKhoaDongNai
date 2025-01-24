namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAn_DieuTriRang : BaseModel
    {
        [Key]
        public int? BenhAn_DieuTriRang_Id { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }
public string? NiemMacMieng { get; set; }
public int? Loi_Id { get; set; }
public string? Loi { get; set; }
public string? CaoRang { get; set; }
public string? TuiNhaChu { get; set; }
public string? XQuang { get; set; }
public string? XetNghiem { get; set; }
public int? DinhBenh_Id { get; set; }

        public BenhAn_DieuTriRang()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_LoaiBenhAn : BaseModel
    {
        [Key]
        public int? LoaiBenhAn_Id { get; set; }
public int? NhomLoaiBenhAn_Id { get; set; }
public string? MaLoaiBenhAn { get; set; }
public string? MaLoaiBenhAn_Map { get; set; }
public string? TenLoaiBenhAn { get; set; }
public string? TenLoaiBenhAn_En { get; set; }
public string? TenLoaiBenhAn_Ru { get; set; }
public int? Cap { get; set; }
public int? CapTren_Id { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public string? Property1 { get; set; }
public string? Property2 { get; set; }
public string? Property3 { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DM_LoaiBenhAn()
        {
        }
    }
}


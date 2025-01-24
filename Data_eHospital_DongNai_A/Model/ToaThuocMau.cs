namespace Data_eHospital_DongNai_A.Model
{
    public partial class ToaThuocMau : BaseModel
    {
        [Key]
        public int? ToaThuocMau_Id { get; set; }
public int? BacSi_Id { get; set; }
public string? MaToaThuoc { get; set; }
public string? TenToaThuoc { get; set; }
public int? Duoc_Id { get; set; }
public decimal? Sang { get; set; }
public decimal? Trua { get; set; }
public decimal? Chieu { get; set; }
public decimal? Toi { get; set; }
public int? SoNgay { get; set; }
public decimal? SoLuong { get; set; }
public int? DuongDung_Id { get; set; }
public string? GhiChu { get; set; }
public string? DienGiai { get; set; }
public int? idx { get; set; }
public string? LoaiToaThuoc { get; set; }

        public ToaThuocMau()
        {
        }
    }
}


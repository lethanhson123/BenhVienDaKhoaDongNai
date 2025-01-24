namespace Data_eHospital_DongNai_A.Model
{
    public partial class TonKho : BaseModel
    {
        [Key]
        public string? PhamVi { get; set; }
public string? NguonDuoc { get; set; }
public string? LoaiDuoc { get; set; }
public string? TenLoaiDuoc { get; set; }
public int? Duoc_ID { get; set; }
public string? MaDuoc { get; set; }
public string? TenDuoc { get; set; }
public string? DonViTinh { get; set; }
public decimal? Ton { get; set; }
public decimal? LuongNhap { get; set; }
public decimal? LuongXuat { get; set; }
public decimal? LuongTon { get; set; }

        public TonKho()
        {
        }
    }
}


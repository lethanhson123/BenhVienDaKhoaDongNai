namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSKetQuaKhangSinhDo_His : BaseModel
    {
        [Key]
        public int? KetQuaKhangSinhDo_Id { get; set; }
public int? CLSKetQua_Id { get; set; }
public int? KhangSinhDo_Id { get; set; }
public int? NhomKhangSinhDo_Id { get; set; }
public string? TenNguonXetNghiem { get; set; }
public string? KetQua { get; set; }
public bool? KhangSinhDo { get; set; }
public int? LanCapNhat { get; set; }
public DateTime? ThoiGianCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? InstrMIC { get; set; }
public string? FinalSIR { get; set; }
public string? Rules { get; set; }

        public CLSKetQuaKhangSinhDo_His()
        {
        }
    }
}


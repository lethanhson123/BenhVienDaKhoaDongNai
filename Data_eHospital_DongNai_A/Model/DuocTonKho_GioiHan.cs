namespace Data_eHospital_DongNai_A.Model
{
    public partial class DuocTonKho_GioiHan : BaseModel
    {
        [Key]
        public int? DuocTonKho_GioiHan_Id { get; set; }
public int? Duoc_Id { get; set; }
public int? KhoDuoc_Id { get; set; }
public int? NguonHang_Id { get; set; }
public string? SoLuong { get; set; }
public bool? Enabled { get; set; }

        public DuocTonKho_GioiHan()
        {
        }
    }
}


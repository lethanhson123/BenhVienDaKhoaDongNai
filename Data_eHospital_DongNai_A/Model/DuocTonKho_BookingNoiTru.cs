namespace Data_eHospital_DongNai_A.Model
{
    public partial class DuocTonKho_BookingNoiTru : BaseModel
    {
        [Key]
        public int? KhoDuoc_Id { get; set; }
public int? NguonHang_Id { get; set; }
public int? Duoc_Id { get; set; }
public decimal? SoLuong { get; set; }
public DateTime? NgayHieuLuc { get; set; }

        public DuocTonKho_BookingNoiTru()
        {
        }
    }
}


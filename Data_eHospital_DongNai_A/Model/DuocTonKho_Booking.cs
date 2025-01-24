namespace Data_eHospital_DongNai_A.Model
{
    public partial class DuocTonKho_Booking : BaseModel
    {
        [Key]
        public int? Booking_Id { get; set; }
public int? KhoDuoc_Id { get; set; }
public int? NguonHang_Id { get; set; }
public int? Duoc_Id { get; set; }
public decimal? SoLuong { get; set; }
public DateTime? NgayHieuLuc { get; set; }

        public DuocTonKho_Booking()
        {
        }
    }
}


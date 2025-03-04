namespace Data.Model
{
    public partial class HRBangLuong : BaseModel
    {
        
public DateTime? NgayGhiNhan { get; set; }
public int? Year { get; set; }
public int? Month { get; set; }
public int? Day { get; set; }
public decimal? ChamCong { get; set; }
public decimal? Luong { get; set; }
public decimal? PhuCap { get; set; }
public decimal? GiamTru { get; set; }
public decimal? Thue { get; set; }
public decimal? ThanhTien { get; set; }

        public HRBangLuong()
        {
        }
    }
}


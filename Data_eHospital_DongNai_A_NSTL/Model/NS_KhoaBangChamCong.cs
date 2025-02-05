namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_KhoaBangChamCong : BaseModel
    {
        [Key]
        public int? NS_KhoaBangChamCong_Id { get; set; }
public string? MaPhongBan { get; set; }
public DateTime? NgayKhoa { get; set; }
public int? Thang { get; set; }
public int? Nam { get; set; }
public bool? Khoa { get; set; }
public DateTime? TuNgay { get; set; }
public DateTime? DenNgay { get; set; }
public bool? Khoa_LamThem { get; set; }

        public NS_KhoaBangChamCong()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class DuocKyTonKho : BaseModel
    {
        [Key]
        public int? DuocKyTonKho_Id { get; set; }
public string? MaKyTonKho { get; set; }
public int? Thang { get; set; }
public int? Nam { get; set; }
public DateTime? TuNgay { get; set; }
public DateTime? DenNgay { get; set; }
public bool? KhoaSo { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DuocKyTonKho()
        {
        }
    }
}


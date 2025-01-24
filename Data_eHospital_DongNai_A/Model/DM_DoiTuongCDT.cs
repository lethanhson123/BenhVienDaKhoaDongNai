namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_DoiTuongCDT : BaseModel
    {
        [Key]
        public int? DoiTuong_Id { get; set; }
public string? MaDoiTuong { get; set; }
public string? TenDoiTuong { get; set; }
public bool? TamNgung { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DM_DoiTuongCDT()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class NoiTru_TuThi : BaseModel
    {
        [Key]
        public int? TuThi_Id { get; set; }
public int? BenhAn_Id { get; set; }
public DateTime? NgayTuVong { get; set; }
public DateTime? ThoiGianTuVong { get; set; }
public DateTime? ThoiGianKhamNghiem { get; set; }
public DateTime? ThoiGianNhanTuThi { get; set; }
public string? KetQuaKhamNghiem { get; set; }
public string? GhiChu { get; set; }
public int? NguyenNhanTuVong_Id { get; set; }
public int? BacSiGhiNhanTuVong_Id { get; set; }
public int? BacSiKhamNghiem_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public NoiTru_TuThi()
        {
        }
    }
}


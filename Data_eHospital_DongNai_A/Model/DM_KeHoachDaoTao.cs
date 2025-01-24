namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_KeHoachDaoTao : BaseModel
    {
        [Key]
        public int? KhoaHoc_Id { get; set; }
public string? MaKhoaHoc { get; set; }
public string? TenKhoaHoc { get; set; }
public DateTime? NgayBatDau { get; set; }
public DateTime? NgayKetThuc { get; set; }
public string? DiaDiem { get; set; }
public int? LoaiKhoaHoc_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? GoiKT { get; set; }
public DateTime? ThoiGianDT { get; set; }
public int? SCApDung { get; set; }
public int? SCCoKQTot { get; set; }
public int? SCTaiBien { get; set; }
public int? SCChuyenTuyen { get; set; }
public int? SCTuVong { get; set; }
public string? GhiChu { get; set; }

        public DM_KeHoachDaoTao()
        {
        }
    }
}


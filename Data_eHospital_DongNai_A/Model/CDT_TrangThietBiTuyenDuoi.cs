namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_TrangThietBiTuyenDuoi : BaseModel
    {
        [Key]
        public int? CDT_TrangThietBi_Id { get; set; }
public int? ThietBi_Id { get; set; }
public int? BenhVien_Id { get; set; }
public int? TinhTrang_Id { get; set; }
public DateTime? NgayQuanLy { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? GhiChu { get; set; }

        public CDT_TrangThietBiTuyenDuoi()
        {
        }
    }
}


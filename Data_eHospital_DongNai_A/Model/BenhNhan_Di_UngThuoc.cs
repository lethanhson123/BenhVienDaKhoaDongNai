namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhNhan_Di_UngThuoc : BaseModel
    {
        [Key]
        public int? BenhNhan_Di_UngThuoc_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? Duoc_Id { get; set; }
public DateTime? NgayPhatHien { get; set; }
public string? TinhTrang { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_id { get; set; }
public int? NhanVien_Id { get; set; }

        public BenhNhan_Di_UngThuoc()
        {
        }
    }
}


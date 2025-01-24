namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhNhan_TienCan : BaseModel
    {
        [Key]
        public int? BenhNhan_TienCan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TienCan_Id { get; set; }
public DateTime? NgayPhatHien { get; set; }
public string? TinhTrang { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public BenhNhan_TienCan()
        {
        }
    }
}


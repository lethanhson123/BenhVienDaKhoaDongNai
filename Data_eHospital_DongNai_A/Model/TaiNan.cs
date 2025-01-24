namespace Data_eHospital_DongNai_A.Model
{
    public partial class TaiNan : BaseModel
    {
        [Key]
        public int? TaiNan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public DateTime? NgayTaiNan { get; set; }
public int? DiaDiem_Id { get; set; }
public int? NguyenNhan_Id { get; set; }
public int? MucDo_Id { get; set; }
public int? BoPhan_Id { get; set; }
public int? NgoDoc_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? BoPhan { get; set; }

        public TaiNan()
        {
        }
    }
}


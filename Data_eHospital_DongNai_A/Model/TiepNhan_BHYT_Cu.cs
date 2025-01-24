namespace Data_eHospital_DongNai_A.Model
{
    public partial class TiepNhan_BHYT_Cu : BaseModel
    {
        [Key]
        public int? TiepNhan_BHYT_Cu_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public string? SoBHYT { get; set; }
public DateTime? BHYTTuNgay { get; set; }
public DateTime? BHYTDenNgay { get; set; }
public int? DoiTuong_Id { get; set; }
public int? DoiTuong_ChiTiet_Id { get; set; }
public int? BenhVien_KCB_Id { get; set; }
public int? TuyenKhamBenh_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public TiepNhan_BHYT_Cu()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class XacNhanChiPhi_TestStent : BaseModel
    {
        [Key]
        public int? XacNhanChiPhi_Id { get; set; }
public string? SoXacNhan { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? DoiTuong_Id { get; set; }
public string? SoBHYT { get; set; }
public DateTime? NgayVao { get; set; }
public DateTime? NgayRa { get; set; }
public DateTime? NgayKham { get; set; }
public string? ChanDoan { get; set; }
public string? Loai { get; set; }
public DateTime? NgayXacNhan { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? BenhVien_id { get; set; }
public int? IDChuyen { get; set; }
public int? IDChuyenHuy { get; set; }
public int? IDChuyenHoan { get; set; }
public string? TuyenKhamBenh { get; set; }
public DateTime? ThoiGianXacNhan { get; set; }
public DateTime? NgayXuatThuoc { get; set; }
public int? NoiXacNhan_ID { get; set; }
public string? MaBenh { get; set; }
public string? BenhKhac { get; set; }
public string? TenPhongKham { get; set; }
public int? Center_XN_ID { get; set; }
public DateTime? Center_ThoiGianChuyen { get; set; }
public int? OtherSite_XacNhanChiPhi_ID { get; set; }
public bool? Export { get; set; }

        public XacNhanChiPhi_TestStent()
        {
        }
    }
}


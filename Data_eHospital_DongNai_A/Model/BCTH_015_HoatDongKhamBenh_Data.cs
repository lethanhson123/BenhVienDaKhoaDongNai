namespace Data_eHospital_DongNai_A.Model
{
    public partial class BCTH_015_HoatDongKhamBenh_Data : BaseModel
    {
        [Key]
        public string? TenPhongBan { get; set; }
public int? TongSo { get; set; }
public int? VienPhi { get; set; }
public int? BHYT { get; set; }
public int? KhongThuDuoc { get; set; }
public int? VaoVien { get; set; }
public int? ChuyenVien { get; set; }
public int? CapCuu { get; set; }
public int? Nguoi_NgoaiTru { get; set; }
public int? Ngay_NgoaiTru { get; set; }
public string? TC { get; set; }
public int? Phongban_id { get; set; }
public int? CapTren_id { get; set; }
public int? Thang { get; set; }
public int? Nam { get; set; }

        public BCTH_015_HoatDongKhamBenh_Data()
        {
        }
    }
}


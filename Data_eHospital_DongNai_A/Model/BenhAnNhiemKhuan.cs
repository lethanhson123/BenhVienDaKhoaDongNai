namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnNhiemKhuan : BaseModel
    {
        [Key]
        public int? BenhAnNhiemKhuan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public DateTime? Ngay { get; set; }
public int? NhiemKhuanTT_Id { get; set; }
public int? NhiemKhuanBV_Id { get; set; }
public int? LoaiThuThuat_Id { get; set; }
public string? TacNhan { get; set; }
public int? LyDoNhiemKhuan_Id { get; set; }
public string? PhuongPhapDieuTri { get; set; }
public string? LoiDanThayThuoc { get; set; }
public string? ChanDoanRaVien { get; set; }
public string? Attribute_1 { get; set; }
public string? Attribute_2 { get; set; }
public string? Attribute_3 { get; set; }
public string? Attribute_4 { get; set; }

        public BenhAnNhiemKhuan()
        {
        }
    }
}


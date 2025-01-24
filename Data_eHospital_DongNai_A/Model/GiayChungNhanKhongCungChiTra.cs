namespace Data_eHospital_DongNai_A.Model
{
    public partial class GiayChungNhanKhongCungChiTra : BaseModel
    {
        [Key]
        public int? GiayChungNhan_ID { get; set; }
public string? SoGiayChungNhan { get; set; }
public int? TiepNhan_ID { get; set; }
public int? BenhAn_ID { get; set; }
public int? BenhNhan_ID { get; set; }
public DateTime? GiaTri_TuNgay { get; set; }
public DateTime? GiaTri_DenNgay { get; set; }
public int? NoiDangKyKham_ID { get; set; }
public DateTime? Du5Nam_TuNgay { get; set; }
public DateTime? ThoiDiemCungChiTra { get; set; }
public int? DoiTuong_ID { get; set; }
public string? SoTheBHYT { get; set; }
public DateTime? BHYT_TuNgay { get; set; }
public DateTime? BHYT_DenNgay { get; set; }
public DateTime? HieuLuc_TuNgay { get; set; }
public DateTime? HieuLuc_DenNgay { get; set; }
public int? NguoiTao_ID { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_ID { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public GiayChungNhanKhongCungChiTra()
        {
        }
    }
}


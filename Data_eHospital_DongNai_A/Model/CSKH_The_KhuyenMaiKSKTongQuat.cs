namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_The_KhuyenMaiKSKTongQuat : BaseModel
    {
        [Key]
        public int? The_KSKTongQuat_Id { get; set; }
public int? The_Id { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public decimal? TyLe { get; set; }
public int? SoLan { get; set; }
public int? TuoiMin { get; set; }
public int? TuoiMax { get; set; }
public bool? CoHen { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? CTKhamSucKhoe_Id { get; set; }
public bool? TatCaChuongTrinhKSK { get; set; }
public int? SoLanSuDung { get; set; }

        public CSKH_The_KhuyenMaiKSKTongQuat()
        {
        }
    }
}


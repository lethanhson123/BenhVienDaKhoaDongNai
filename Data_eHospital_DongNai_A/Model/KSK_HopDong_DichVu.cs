namespace Data_eHospital_DongNai_A.Model
{
    public partial class KSK_HopDong_DichVu : BaseModel
    {
        [Key]
        public int? HopDong_DichVu_Id { get; set; }
public int? HopDong_Id { get; set; }
public int? DichVu_Id { get; set; }
public int? PhongBan_Id { get; set; }
public string? DonGiaPhaiThu { get; set; }
public string? DonGia { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public string? MoTa { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? Idx { get; set; }

        public KSK_HopDong_DichVu()
        {
        }
    }
}


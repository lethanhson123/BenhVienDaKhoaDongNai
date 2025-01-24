namespace Data_eHospital_DongNai_A.Model
{
    public partial class NoiTru_DichVu : BaseModel
    {
        [Key]
        public int? NoiTru_DichVu_Id { get; set; }
public string? SoPhieu { get; set; }
public int? BenhAn_Id { get; set; }
public int? LuuTru_Id { get; set; }
public DateTime? NgayYeuCau { get; set; }
public DateTime? ThoiGianYeuCau { get; set; }
public int? BacSi_Id { get; set; }
public int? NhomDichVu_Id { get; set; }
public int? DichVu_Id { get; set; }
public int? SoLuong { get; set; }
public string? DonGiaPhaiThu { get; set; }
public string? DonGia { get; set; }
public string? TyLeVAT { get; set; }
public string? GiaTriVAT { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public int? LoaiGia_Id { get; set; }
public bool? MoTim { get; set; }
public bool? ThucHienTaiPhongMo { get; set; }
public int? NoiThucHien_Id { get; set; }
public int? NguonMau_Id { get; set; }
public string? GhiChu { get; set; }
public bool? CoKetQua { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? KetQua { get; set; }
public DateTime? NgayThucHien { get; set; }
public DateTime? ThoiGianThucHien { get; set; }
public bool? MienPhi { get; set; }

        public NoiTru_DichVu()
        {
        }
    }
}


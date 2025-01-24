namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSKetQuaChiTiet_Version : BaseModel
    {
        [Key]
        public int? CLSKetQuaChiTiet_Version_Id { get; set; }
public int? CLSKetQua_Version_Id { get; set; }
public int? DichVu_Id { get; set; }
public string? DonViTinh { get; set; }
public string? KetQua { get; set; }
public string? KetQua2 { get; set; }
public string? MucBinhThuong { get; set; }
public string? MucBinhThuongMin { get; set; }
public string? MucBinhThuongMax { get; set; }
public bool? BatThuong { get; set; }
public bool? ThucHienBenNgoai { get; set; }

        public CLSKetQuaChiTiet_Version()
        {
        }
    }
}


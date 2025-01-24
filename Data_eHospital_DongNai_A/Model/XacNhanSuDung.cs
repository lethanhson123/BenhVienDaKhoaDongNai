namespace Data_eHospital_DongNai_A.Model
{
    public partial class XacNhanSuDung : BaseModel
    {
        [Key]
        public int? XacNhanSuDung_Id { get; set; }
public int? YeuCauChiTiet_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? DichVu_Id { get; set; }
public int? PhongBan_Id { get; set; }
public int? SoLuong { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public DateTime? NgayXacNhan { get; set; }
public int? NguoiThucHien_Id { get; set; }
public int? NoiThucHien_Id { get; set; }
public int? KhoaDieuTri { get; set; }

        public XacNhanSuDung()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_LichCongTac_KetQua : BaseModel
    {
        [Key]
        public int? CDT_LichCongTac_KetQua_Id { get; set; }
public int? CDT_LichCongTac_Id { get; set; }
public string? KetQua { get; set; }
public int? SoNguoiThamGia { get; set; }
public decimal? SoNgayThucHien { get; set; }
public string? ThanhPhanThamGia { get; set; }
public int? CDT_PhanLoaiKetQua_Id { get; set; }
public decimal? KinhPhiThucHien { get; set; }

        public CDT_LichCongTac_KetQua()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAn_PhauThuatTrongMieng : BaseModel
    {
        [Key]
        public int? BenhAn_PhauThuatTrongMieng_Id { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }
public string? TSB_Mau { get; set; }
public string? TSB_TimMach { get; set; }
public string? TSB_TieuDuong { get; set; }
public string? TSB_BenhKhac { get; set; }
public int? TienLuong_Id { get; set; }
public string? CKM_TenNguoiThan { get; set; }
public string? CKM_DiaChi { get; set; }
public string? CKM_DienThoai { get; set; }
public DateTime? CKM_NgayCamKet { get; set; }

        public BenhAn_PhauThuatTrongMieng()
        {
        }
    }
}


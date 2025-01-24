namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSKetQuaXNHuyet_TuyDo : BaseModel
    {
        [Key]
        public int? ClsKetQuaXNHuyet_TuyDo_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public string? MaSoPhieu { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? BacSiChiDinh_Id { get; set; }
public int? BacSiKetLuan_Id { get; set; }
public int? KyThuatVien_Id { get; set; }
public DateTime? NgayGioThucHien { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public string? LamTuy { get; set; }
public string? LamMau { get; set; }
public int? MauCheckList_Id { get; set; }
public string? HoaTeBao { get; set; }
public string? KetLuan { get; set; }
public string? DeNghi { get; set; }
public int? NoiThucHien_Id { get; set; }
public int? DichVu_Id { get; set; }
public int? YeuCauChiTiet_Id { get; set; }
public int? ClsKetQua_Id { get; set; }
public DateTime? NgayThucHien { get; set; }

        public CLSKetQuaXNHuyet_TuyDo()
        {
        }
    }
}


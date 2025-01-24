namespace Data_eHospital_DongNai_A.Model
{
    public partial class ThuPhanUngThuocCoHai_ThuocGayNghiNgoADR : BaseModel
    {
        [Key]
        public int? ThuocGayNghiNgoADR_Id { get; set; }
public int? PhanUngThuocCoHai_Id { get; set; }
public int? Duoc_Id { get; set; }
public string? HamLuong { get; set; }
public string? LieuDungMotLan { get; set; }
public string? SoLanDung { get; set; }
public int? DuongDung_Id { get; set; }
public DateTime? NgayBatDau { get; set; }
public DateTime? NgayKetThuc { get; set; }
public DateTime? HanSuDung { get; set; }
public int? HangSanXuat_Id { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public string? LyDoDungThuoc { get; set; }

        public ThuPhanUngThuocCoHai_ThuocGayNghiNgoADR()
        {
        }
    }
}


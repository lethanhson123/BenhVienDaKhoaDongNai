namespace Data_eHospital_DongNai_A.Model
{
    public partial class ThuPhanUngThuocCoHai_ThuocSuDungDongThoi : BaseModel
    {
        [Key]
        public int? ThuocSuDungDongThoi_Id { get; set; }
public int? PhanUngThuocCoHai_Id { get; set; }
public int? Duoc_Id { get; set; }
public int? DonViTinh_Id { get; set; }
public int? SoNgay { get; set; }
public DateTime? NgayBatDau { get; set; }
public DateTime? NgayKetThuc { get; set; }
public string? HamLuong { get; set; }

        public ThuPhanUngThuocCoHai_ThuocSuDungDongThoi()
        {
        }
    }
}


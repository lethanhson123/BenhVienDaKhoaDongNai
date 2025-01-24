namespace Data_eHospital_DongNai_A.Model
{
    public partial class DuocTonKho_BookPhamVi : BaseModel
    {
        [Key]
        public int? DuocTonKho_BookPhamVi_ID { get; set; }
public int? PhamVi_ID { get; set; }
public int? NoiTru_ToaThuoc_ID { get; set; }
public int? Duoc_ID { get; set; }
public decimal? SoLuong { get; set; }
public int? NguonHang_Id { get; set; }
public DateTime? NgayHieuLuc { get; set; }
public int? KhoCoSo_Id { get; set; }
public int? BenhAnNgoaiTru_ToaThuoc_ID { get; set; }

        public DuocTonKho_BookPhamVi()
        {
        }
    }
}


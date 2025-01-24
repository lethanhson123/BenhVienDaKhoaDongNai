namespace Data_eHospital_DongNai_A.Model
{
    public partial class Transfer_VienPhi_ChiTiet : BaseModel
    {
        [Key]
        public int? Transfer_VienPhi_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public DateTime? NgayChungTu { get; set; }
public int? IDRef { get; set; }
public string? Loai_IDRef { get; set; }
public string? LoaiNoiDung { get; set; }
public int? NoiDung_Id { get; set; }
public decimal? SoLuong { get; set; }
public decimal? ThanhTien { get; set; }
public string? MaDoiTuong { get; set; }
public decimal? VAT { get; set; }

        public Transfer_VienPhi_ChiTiet()
        {
        }
    }
}


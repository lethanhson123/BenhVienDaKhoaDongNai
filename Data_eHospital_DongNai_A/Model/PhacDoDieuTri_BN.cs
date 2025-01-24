namespace Data_eHospital_DongNai_A.Model
{
    public partial class PhacDoDieuTri_BN : BaseModel
    {
        [Key]
        public int? PDDT_BN_ID { get; set; }
public string? MaPhacDo { get; set; }
public string? SoBenhAn { get; set; }
public int? Khoa_Id { get; set; }
public DateTime? NgayDieuTri { get; set; }
public string? GhiChu { get; set; }
public int? ChuKy_Id { get; set; }
public int? TrangThai { get; set; }

        public PhacDoDieuTri_BN()
        {
        }
    }
}


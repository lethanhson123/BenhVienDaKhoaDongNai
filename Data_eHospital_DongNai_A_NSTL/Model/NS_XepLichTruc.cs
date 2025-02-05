namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_XepLichTruc : BaseModel
    {
        [Key]
        public int? XepLichTruc_Id { get; set; }
public DateTime? NgayTruc { get; set; }
public string? Thu { get; set; }
public int? NhanVien_Id { get; set; }
public int? LoaiTruc_Id { get; set; }
public int? PhongBan_Id { get; set; }
public int? CaTruc_Id { get; set; }
public DateTime? BatDau { get; set; }
public DateTime? KetThuc { get; set; }
public string? GhiChu { get; set; }

        public NS_XepLichTruc()
        {
        }
    }
}


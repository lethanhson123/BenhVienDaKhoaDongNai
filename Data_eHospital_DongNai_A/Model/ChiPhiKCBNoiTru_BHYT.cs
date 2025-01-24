namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChiPhiKCBNoiTru_BHYT : BaseModel
    {
        [Key]
        public int? Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? DoiTuong_Id { get; set; }
public string? SoBHYT { get; set; }
public DateTime? NgayVaoVien { get; set; }
public DateTime? NgayRaVien { get; set; }
public string? SoNgay { get; set; }
public string? TienPhong { get; set; }
public string? Thuoc { get; set; }
public string? DichTruyen { get; set; }
public string? XetNghiem { get; set; }
public string? SieuAm { get; set; }
public string? DienTim { get; set; }
public string? DienNao { get; set; }
public string? XQuang { get; set; }
public string? CT { get; set; }
public string? NoiSoi { get; set; }
public string? ThuThuat { get; set; }
public string? VTYT { get; set; }
public string? DichVuYTe { get; set; }
public string? Khac { get; set; }

        public ChiPhiKCBNoiTru_BHYT()
        {
        }
    }
}


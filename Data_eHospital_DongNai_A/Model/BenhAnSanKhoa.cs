namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnSanKhoa : BaseModel
    {
        [Key]
        public int? BenhAn_Id { get; set; }
public string? LoaiPhaThai { get; set; }
public bool? TaiBienDoPhaThai { get; set; }
public bool? TrietSanNgoaiThaiKy { get; set; }
public bool? NhiemTrungVetMo { get; set; }
public bool? NoiSoi { get; set; }
public bool? TuyenDuoiChuyen { get; set; }
public string? Para1 { get; set; }
public string? Para2 { get; set; }
public string? Para3 { get; set; }
public string? Para4 { get; set; }
public string? PhuongPhapSinh { get; set; }
public string? SoCon { get; set; }

        public BenhAnSanKhoa()
        {
        }
    }
}


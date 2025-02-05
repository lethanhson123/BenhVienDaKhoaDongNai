namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_QUANHEGIADINH : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaQuanHe { get; set; }
public string? MaNhanVien { get; set; }
public string? HoTen { get; set; }
public string? NamSinh { get; set; }
public string? NgheNghiep { get; set; }
public string? Diachi { get; set; }
public int? TinhTrangQuanHe_ID { get; set; }
public bool? PhuThuoc { get; set; }

        public NS_QUANHEGIADINH()
        {
        }
    }
}


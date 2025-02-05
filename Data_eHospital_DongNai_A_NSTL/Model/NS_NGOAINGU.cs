namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_NGOAINGU : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaNhanVien { get; set; }
public string? MaTDNgoaiNgu { get; set; }
public string? Trinhdo { get; set; }
public string? Nghe { get; set; }
public string? Noi { get; set; }
public string? Doc { get; set; }
public string? Viet { get; set; }
public int? TrinhDoChiTiet_Id { get; set; }
public string? NgayCap { get; set; }

        public NS_NGOAINGU()
        {
        }
    }
}


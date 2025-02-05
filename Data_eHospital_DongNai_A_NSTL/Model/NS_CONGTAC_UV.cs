namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_CONGTAC_UV : BaseModel
    {
        [Key]
        public int? id { get; set; }
public string? MaUngVien { get; set; }
public string? Congty { get; set; }
public DateTime? Tungay { get; set; }
public DateTime? Denngay { get; set; }
public string? Phongban { get; set; }
public string? ToNhom { get; set; }
public string? Chucvu { get; set; }
public string? Congviec { get; set; }

        public NS_CONGTAC_UV()
        {
        }
    }
}


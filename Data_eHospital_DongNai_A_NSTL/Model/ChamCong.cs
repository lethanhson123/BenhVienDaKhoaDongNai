namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class ChamCong : BaseModel
    {
        [Key]
        public string? ID { get; set; }
public string? MaTheChamCong { get; set; }
public DateTime? NgayGioVao { get; set; }
public DateTime? NgayGioRa { get; set; }
public string? SoGioLam { get; set; }
public string? MayQuetThe { get; set; }
public string? GhiChu { get; set; }
public string? SoGioLamThem { get; set; }
public DateTime? NgayChamCong { get; set; }
public bool? Truc { get; set; }
public DateTime? GioVaoChuan { get; set; }
public DateTime? GioRaChuan { get; set; }

        public ChamCong()
        {
        }
    }
}


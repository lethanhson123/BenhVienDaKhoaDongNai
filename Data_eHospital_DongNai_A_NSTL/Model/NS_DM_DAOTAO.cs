namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_DAOTAO : BaseModel
    {
        [Key]
        public string? Masodaotao { get; set; }
public string? Noidungdaotao { get; set; }
public DateTime? Tungay { get; set; }
public DateTime? Denngay { get; set; }
public string? Giohoc { get; set; }
public string? Chiphicongty { get; set; }
public string? Chiphicanhan { get; set; }
public string? Noidaotao { get; set; }
public string? Donvidaotao { get; set; }
public string? Hinhthucdaotao { get; set; }
public string? Bangcap { get; set; }
public string? PhanTramDong { get; set; }

        public NS_DM_DAOTAO()
        {
        }
    }
}


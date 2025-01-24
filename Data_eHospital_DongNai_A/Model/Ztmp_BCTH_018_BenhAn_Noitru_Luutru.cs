namespace Data_eHospital_DongNai_A.Model
{
    public partial class Ztmp_BCTH_018_BenhAn_Noitru_Luutru : BaseModel
    {
        [Key]
        public int? Luutru_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? PhongBan_Id { get; set; }
public DateTime? NgayVao { get; set; }
public DateTime? ThoiGianVao { get; set; }
public DateTime? NgayRa { get; set; }
public DateTime? ThoiGianRa { get; set; }
public string? LyDoVao_Code { get; set; }
public string? LyDoRa_Code { get; set; }

        public Ztmp_BCTH_018_BenhAn_Noitru_Luutru()
        {
        }
    }
}


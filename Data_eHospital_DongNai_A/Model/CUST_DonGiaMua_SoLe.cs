namespace Data_eHospital_DongNai_A.Model
{
    public partial class CUST_DonGiaMua_SoLe : BaseModel
    {
        [Key]
        public int? SEQ { get; set; }
public int? ChungTuChiTiet_id { get; set; }
public string? DonGiaMua { get; set; }
public DateTime? NgayTao { get; set; }

        public CUST_DonGiaMua_SoLe()
        {
        }
    }
}


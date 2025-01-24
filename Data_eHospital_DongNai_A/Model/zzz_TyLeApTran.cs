namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzz_TyLeApTran : BaseModel
    {
        [Key]
        public string? SoVaoVien { get; set; }
public DateTime? NgayVao { get; set; }
public DateTime? NgayRa { get; set; }

        public zzz_TyLeApTran()
        {
        }
    }
}


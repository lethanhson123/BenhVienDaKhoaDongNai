namespace Data_eHospital_DongNai_A.Model
{
    public partial class BHYT_KiemTra : BaseModel
    {
        [Key]
        public string? ma_the { get; set; }
public string? ho_ten { get; set; }
public DateTime? ngay_vao { get; set; }
public DateTime? ngay_ra { get; set; }

        public BHYT_KiemTra()
        {
        }
    }
}


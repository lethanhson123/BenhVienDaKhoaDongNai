namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class ZZZ_NhanVienSOBHXH : BaseModel
    {
        [Key]
        public int? STT { get; set; }
public string? MA_BHXH { get; set; }
public string? HO_TEN { get; set; }
public int? GIOI_TINH { get; set; }
public string? MACCHN { get; set; }

        public ZZZ_NhanVienSOBHXH()
        {
        }
    }
}


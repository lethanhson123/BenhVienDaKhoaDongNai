namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_CHAMCONG : BaseModel
    {
        [Key]
        public string? ID { get; set; }
public string? MaNhanVien { get; set; }
public DateTime? Ngaylamviec { get; set; }

        public NS_CHAMCONG()
        {
        }
    }
}


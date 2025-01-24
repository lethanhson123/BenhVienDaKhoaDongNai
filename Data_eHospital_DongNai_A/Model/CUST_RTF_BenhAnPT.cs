namespace Data_eHospital_DongNai_A.Model
{
    public partial class CUST_RTF_BenhAnPT : BaseModel
    {
        [Key]
        public int? BenhAnPhauThuat_Id { get; set; }
public string? TrinhTuThucHien { get; set; }
public string? TrinhTuThucHien_Convert { get; set; }
public int? DaXuLy { get; set; }

        public CUST_RTF_BenhAnPT()
        {
        }
    }
}


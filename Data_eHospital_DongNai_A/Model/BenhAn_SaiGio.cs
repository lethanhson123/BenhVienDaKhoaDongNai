namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAn_SaiGio : BaseModel
    {
        [Key]
        public int? BenhAn_Id { get; set; }
public DateTime? ThoiGianRaVien { get; set; }
public int? DaUpdate { get; set; }

        public BenhAn_SaiGio()
        {
        }
    }
}


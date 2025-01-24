namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoSoSucKhoe_TiepXuc : BaseModel
    {
        [Key]
        public int? TiepXuc_Id { get; set; }
public int? HoSoSucKhoe_Id { get; set; }
public int? TinhChat_Id { get; set; }

        public HoSoSucKhoe_TiepXuc()
        {
        }
    }
}


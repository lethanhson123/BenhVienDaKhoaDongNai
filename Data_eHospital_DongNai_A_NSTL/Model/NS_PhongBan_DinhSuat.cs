namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_PhongBan_DinhSuat : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public int? PhongBan_Id { get; set; }
public int? DinhSuat_Id { get; set; }

        public NS_PhongBan_DinhSuat()
        {
        }
    }
}


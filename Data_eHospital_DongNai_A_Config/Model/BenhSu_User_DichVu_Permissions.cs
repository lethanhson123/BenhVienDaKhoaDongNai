namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class BenhSu_User_DichVu_Permissions : BaseModel
    {
        [Key]
        public int? Group_Id { get; set; }
public int? User_Id { get; set; }
public int? DichVu_Id { get; set; }

        public BenhSu_User_DichVu_Permissions()
        {
        }
    }
}


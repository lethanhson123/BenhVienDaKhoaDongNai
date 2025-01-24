namespace Data_eHospital_DongNai_A.Model
{
    public partial class Map_PB_Group_Kios : BaseModel
    {
        [Key]
        public int? Map_PB_Group_Kios_id { get; set; }
public int? Group_PB_Kios_Id { get; set; }
public int? PhongBan_Id { get; set; }

        public Map_PB_Group_Kios()
        {
        }
    }
}


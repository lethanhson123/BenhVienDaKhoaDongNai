namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_MenuList : BaseModel
    {
        [Key]
        public int? Menu_id { get; set; }
public string? Menu_Name { get; set; }

        public me_MenuList()
        {
        }
    }
}


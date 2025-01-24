namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_AppList : BaseModel
    {
        [Key]
        public int? APP_id { get; set; }
public string? APP_Name { get; set; }

        public me_AppList()
        {
        }
    }
}


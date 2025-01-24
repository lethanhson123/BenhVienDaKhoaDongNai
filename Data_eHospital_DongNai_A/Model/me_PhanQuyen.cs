namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_PhanQuyen : BaseModel
    {
        [Key]
        public int? PhanQuyen_id { get; set; }
public int? User_id { get; set; }
public int? App_id { get; set; }
public int? Menu_id { get; set; }
public bool? TamNgung { get; set; }

        public me_PhanQuyen()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_VitriCuaTrenForm : BaseModel
    {
        [Key]
        public int? Pos_id { get; set; }
public int? KhuVuc_id { get; set; }
public int? Cua_id { get; set; }
public int? X { get; set; }
public int? Y { get; set; }

        public me_VitriCuaTrenForm()
        {
        }
    }
}


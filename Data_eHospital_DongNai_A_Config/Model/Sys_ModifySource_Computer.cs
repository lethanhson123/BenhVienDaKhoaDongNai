namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class Sys_ModifySource_Computer : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? Computer_Name { get; set; }
public string? IP { get; set; }
public int? Enable { get; set; }
public string? Description { get; set; }

        public Sys_ModifySource_Computer()
        {
        }
    }
}


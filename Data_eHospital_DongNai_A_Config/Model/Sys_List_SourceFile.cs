namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class Sys_List_SourceFile : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? FileName { get; set; }
public string? PathName { get; set; }
public string? Size { get; set; }
public string? ModifyDate { get; set; }

        public Sys_List_SourceFile()
        {
        }
    }
}


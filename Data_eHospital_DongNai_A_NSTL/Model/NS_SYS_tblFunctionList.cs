namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_SYS_tblFunctionList : BaseModel
    {
        [Key]
        public int? FunctionID { get; set; }
public string? FunctionNameV { get; set; }
public string? FunctionNameE { get; set; }
public string? ModuleID { get; set; }
public string? Url { get; set; }
public string? Ascx { get; set; }
public int? Rank { get; set; }
public bool? Display { get; set; }
public string? Left_Horizontal { get; set; }
public int? Parent { get; set; }
public string? cssClass { get; set; }
public string? TitleV { get; set; }
public string? TitleE { get; set; }

        public NS_SYS_tblFunctionList()
        {
        }
    }
}


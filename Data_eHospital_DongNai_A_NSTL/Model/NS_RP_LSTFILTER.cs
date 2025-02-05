namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_RP_LSTFILTER : BaseModel
    {
        [Key]
        public string? FILTER { get; set; }
public string? PARAMETER { get; set; }
public string? CAPTION { get; set; }
public string? DEFAULTVALUE { get; set; }
public bool? CRLF { get; set; }
public string? TYPE_DATA { get; set; }
public string? TABLECHECK { get; set; }
public string? PARAMETERTYPE { get; set; }
public string? PARAMETERNAME { get; set; }
public bool? REPORTFORMULAR { get; set; }
public bool? STOREPARAMETER { get; set; }
public string? READONLY { get; set; }
public bool? SETNAMELABEL { get; set; }

        public NS_RP_LSTFILTER()
        {
        }
    }
}


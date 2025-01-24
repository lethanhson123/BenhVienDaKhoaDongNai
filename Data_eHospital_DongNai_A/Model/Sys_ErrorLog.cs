namespace Data_eHospital_DongNai_A.Model
{
    public partial class Sys_ErrorLog : BaseModel
    {
        [Key]
        public int? ErrorLogID { get; set; }
public DateTime? ErrorTime { get; set; }
public string? UserName { get; set; }
public int? ErrorNumber { get; set; }
public int? ErrorSeverity { get; set; }
public int? ErrorState { get; set; }
public string? ErrorProcedure { get; set; }
public int? ErrorLine { get; set; }
public string? ErrorMessage { get; set; }

        public Sys_ErrorLog()
        {
        }
    }
}


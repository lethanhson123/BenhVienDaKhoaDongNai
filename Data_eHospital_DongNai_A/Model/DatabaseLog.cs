namespace Data_eHospital_DongNai_A.Model
{
    public partial class DatabaseLog : BaseModel
    {
        [Key]
        public int? DatabaseLogID { get; set; }
public DateTime? PostTime { get; set; }
public string? DatabaseUser { get; set; }
public string? Event { get; set; }
public string? Schema { get; set; }
public string? Object { get; set; }
public string? TSQL { get; set; }
public string? XmlEvent { get; set; }

        public DatabaseLog()
        {
        }
    }
}


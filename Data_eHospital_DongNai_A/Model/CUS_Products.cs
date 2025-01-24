namespace Data_eHospital_DongNai_A.Model
{
    public partial class CUS_Products : BaseModel
    {
        [Key]
        public string? Code { get; set; }
public string? Name { get; set; }
public string? Unit { get; set; }
public string? Quantity { get; set; }
public string? Price { get; set; }
public string? Total { get; set; }
public string? Action { get; set; }
public int? Fkey { get; set; }
public string? Extra1 { get; set; }
public string? Extra2 { get; set; }
public string? Remark { get; set; }

        public CUS_Products()
        {
        }
    }
}


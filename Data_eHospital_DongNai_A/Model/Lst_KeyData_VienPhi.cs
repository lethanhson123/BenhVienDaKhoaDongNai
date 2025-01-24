namespace Data_eHospital_DongNai_A.Model
{
    public partial class Lst_KeyData_VienPhi : BaseModel
    {
        [Key]
        public string? KeyType { get; set; }
public int? KeyYear { get; set; }
public int? KeyMonth { get; set; }
public int? KeyDay { get; set; }
public string? Segment_1 { get; set; }
public string? Segment_2 { get; set; }
public string? Segment_3 { get; set; }
public int? KeyValue { get; set; }

        public Lst_KeyData_VienPhi()
        {
        }
    }
}


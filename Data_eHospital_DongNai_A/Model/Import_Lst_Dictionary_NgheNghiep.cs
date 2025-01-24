namespace Data_eHospital_DongNai_A.Model
{
    public partial class Import_Lst_Dictionary_NgheNghiep : BaseModel
    {
        [Key]
        public int? Dictionary_Type_Id { get; set; }
public string? Dictionary_Type_Code { get; set; }
public string? Dictionary_Code { get; set; }
public string? Dictionary_Name { get; set; }
public string? Dictionary_Name_En { get; set; }
public string? Dictionary_Name_Ru { get; set; }
public bool? Enabled { get; set; }
public string? Latin_Name { get; set; }

        public Import_Lst_Dictionary_NgheNghiep()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class DinhNghiaTuDienVietAnh : BaseModel
    {
        [Key]
        public int? DinhNghia_ID { get; set; }
public string? MaDinhNghia { get; set; }
public string? Language_Id { get; set; }
public string? FormName { get; set; }
public string? NoiDung { get; set; }
public string? Attribute1 { get; set; }
public string? Attribute2 { get; set; }
public string? Attribute3 { get; set; }
public string? Attribute4 { get; set; }
public string? Attribute5 { get; set; }

        public DinhNghiaTuDienVietAnh()
        {
        }
    }
}


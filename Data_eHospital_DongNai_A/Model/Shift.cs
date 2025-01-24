namespace Data_eHospital_DongNai_A.Model
{
    public partial class Shift : BaseModel
    {
        [Key]
        public int? Shift_Id { get; set; }
public string? Shift_Name { get; set; }
public string? Shift_Code { get; set; }
public int? Schedule_Type { get; set; }
public DateTime? StartDay { get; set; }
public DateTime? EndDay { get; set; }
public int? Resource_Id { get; set; }
public int? Type_Id { get; set; }
public int? Department_Id { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? Repeat { get; set; }
public DateTime? StartOfWeek { get; set; }
public bool? QuaNgay { get; set; }

        public Shift()
        {
        }
    }
}


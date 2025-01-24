namespace Data_eHospital_DongNai_A.Model
{
    public partial class BienLaiChiTiet : BaseModel
    {
        [Key]
        public int? BienLaiChiTiet_Id { get; set; }
public int? BienLai_Id { get; set; }
public int? NguoiSuDung_Id { get; set; }
public string? MachineName { get; set; }
public int? Start_Number { get; set; }
public int? Current_Number { get; set; }
public DateTime? NgaySuDung { get; set; }
public DateTime? ThoiGianSuDung { get; set; }
public bool? HieuLuc { get; set; }

        public BienLaiChiTiet()
        {
        }
    }
}


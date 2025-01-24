namespace Data_eHospital_DongNai_A.Model
{
    public partial class BienLai : BaseModel
    {
        [Key]
        public int? BienLai_Id { get; set; }
public int? LoaiBienLai_Id { get; set; }
public string? LoaiBienLai { get; set; }
public DateTime? NgayPhatHanh { get; set; }
public DateTime? ThoiGianPhatHanh { get; set; }
public string? KyHieu { get; set; }
public string? Series { get; set; }
public int? Min_Number { get; set; }
public int? Max_Number { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public string? Machine_Name { get; set; }

        public BienLai()
        {
        }
    }
}


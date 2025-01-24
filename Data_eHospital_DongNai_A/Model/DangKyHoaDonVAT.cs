namespace Data_eHospital_DongNai_A.Model
{
    public partial class DangKyHoaDonVAT : BaseModel
    {
        [Key]
        public int? DangKyHoaDon_Id { get; set; }
public string? MachineName { get; set; }
public string? LoaiHoaDon { get; set; }
public DateTime? NgayPhatHanh { get; set; }
public string? SoSeries { get; set; }
public int? Max_No { get; set; }
public int? No_ { get; set; }
public bool? HieuLuc { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }

        public DangKyHoaDonVAT()
        {
        }
    }
}


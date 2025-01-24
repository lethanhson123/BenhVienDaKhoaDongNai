namespace Data_eHospital_DongNai_A.Model
{
    public partial class KiemDiemTuVong_ThanhVien : BaseModel
    {
        [Key]
        public int? KiemDiemTuVong_ThanhVien_Id { get; set; }
public int? KiemDiemTuVong_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? VaiTro_Id { get; set; }

        public KiemDiemTuVong_ThanhVien()
        {
        }
    }
}


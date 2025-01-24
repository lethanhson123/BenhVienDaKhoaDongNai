namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoiChan_EKipMo : BaseModel
    {
        [Key]
        public int? HoiChan_EKipMo_Id { get; set; }
public int? HoiChan_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? VaiTro_Id { get; set; }
public int? Idx { get; set; }

        public HoiChan_EKipMo()
        {
        }
    }
}


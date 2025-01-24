namespace Data_eHospital_DongNai_A.Model
{
    public partial class BienBanHoiChan_Ekip : BaseModel
    {
        [Key]
        public int? BienBanHoiChan_BacSi_Id { get; set; }
public int? BienBanHoiChan_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? VaiTro_Id { get; set; }

        public BienBanHoiChan_Ekip()
        {
        }
    }
}


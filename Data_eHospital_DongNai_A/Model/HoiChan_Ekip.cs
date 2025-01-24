namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoiChan_Ekip : BaseModel
    {
        [Key]
        public int? HoiChan_BacSi_Id { get; set; }
public int? HoiChan_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? VaiTro_Id { get; set; }

        public HoiChan_Ekip()
        {
        }
    }
}


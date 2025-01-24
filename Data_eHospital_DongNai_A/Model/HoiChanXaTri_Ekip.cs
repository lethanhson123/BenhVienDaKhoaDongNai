namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoiChanXaTri_Ekip : BaseModel
    {
        [Key]
        public int? HoiChanXaTri_BacSi_Id { get; set; }
public int? HoiChanXaTri_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? VaiTro_Id { get; set; }

        public HoiChanXaTri_Ekip()
        {
        }
    }
}


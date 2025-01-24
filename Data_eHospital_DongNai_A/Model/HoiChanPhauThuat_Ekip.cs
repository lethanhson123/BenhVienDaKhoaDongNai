namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoiChanPhauThuat_Ekip : BaseModel
    {
        [Key]
        public int? HoiChanPhauThuat_BacSi_Id { get; set; }
public int? HoiChanPhauThuat_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? VaiTro_Id { get; set; }

        public HoiChanPhauThuat_Ekip()
        {
        }
    }
}


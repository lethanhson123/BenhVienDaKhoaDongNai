namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoiChanXaTriTrong_Ekip : BaseModel
    {
        [Key]
        public int? HoiChanXaTriTrongEkip_Id { get; set; }
public int? HoiChanXaTriTrong_Id { get; set; }
public int? NhanVien_Id { get; set; }

        public HoiChanXaTriTrong_Ekip()
        {
        }
    }
}


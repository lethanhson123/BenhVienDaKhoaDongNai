namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_Mapping_DoiTuong_2Khu : BaseModel
    {
        [Key]
        public int? Mapping_ID { get; set; }
public int? DoiTuong_ID { get; set; }
public int? DoiTuong_OtherSite_ID { get; set; }
public int? NguoiTao_ID { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_ID { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public DM_Mapping_DoiTuong_2Khu()
        {
        }
    }
}


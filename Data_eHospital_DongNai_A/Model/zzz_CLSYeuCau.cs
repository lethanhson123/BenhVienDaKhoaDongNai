namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzz_CLSYeuCau : BaseModel
    {
        [Key]
        public int? KhamBenh_ID { get; set; }
public DateTime? ThoiGianKham { get; set; }
public int? NguoiCapNhat_ID { get; set; }
public int? BacSiKham_ID { get; set; }
public int? BenhAn_ID { get; set; }
public int? LuuTru_ID { get; set; }
public int? NguoiTao_ID { get; set; }

        public zzz_CLSYeuCau()
        {
        }
    }
}


namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnTongQuat_TongKet_PhauThuat : BaseModel
    {
        [Key]
        public int? BenhAnTongQuat_ChiTiet_Id { get; set; }
public int? BenhAnTongQuat_Id { get; set; }
public DateTime? ThoiGian { get; set; }
public int? PhuongPhap_Id { get; set; }
public int? BacSiPhauThuat_Id { get; set; }
public int? BacSiGayMe_Id { get; set; }

        public BenhAnTongQuat_TongKet_PhauThuat()
        {
        }
    }
}


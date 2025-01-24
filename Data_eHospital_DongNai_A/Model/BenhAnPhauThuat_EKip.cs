namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnPhauThuat_EKip : BaseModel
    {
        [Key]
        public int? BenhAnPhauThuat_EKip_Id { get; set; }
public int? BenhAnPhauThuat_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? VaiTro_Id { get; set; }
public int? Idx { get; set; }

        public BenhAnPhauThuat_EKip()
        {
        }
    }
}


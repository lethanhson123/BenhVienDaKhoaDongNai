namespace Data_eHospital_DongNai_A.Model
{
    public partial class cus_PhongKham_Time : BaseModel
    {
        [Key]
        public int? PhongBan_id { get; set; }
public string? TGKham_Phut { get; set; }

        public cus_PhongKham_Time()
        {
        }
    }
}


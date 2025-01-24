namespace Data_eHospital_DongNai_A.Model
{
    public partial class cus_BacSiKham_Time : BaseModel
    {
        [Key]
        public int? BacSiKham_id { get; set; }
public string? TGKham_Phut { get; set; }

        public cus_BacSiKham_Time()
        {
        }
    }
}


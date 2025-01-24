namespace Data_eHospital_DongNai_A.Model
{
    public partial class Cust_Backup_BsCCHN : BaseModel
    {
        [Key]
        public int? STT { get; set; }
public int? BenhAn_id { get; set; }
public int? KhamBenh_id { get; set; }
public int? BsKham_Old_id { get; set; }
public int? BsKham_New_id { get; set; }
public DateTime? ThoiGianTao { get; set; }

        public Cust_Backup_BsCCHN()
        {
        }
    }
}


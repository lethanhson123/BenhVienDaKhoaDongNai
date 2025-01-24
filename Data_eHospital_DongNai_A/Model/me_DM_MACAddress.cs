namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_DM_MACAddress : BaseModel
    {
        [Key]
        public int? MAC_id { get; set; }
public string? MacAddress { get; set; }
public string? MoTa { get; set; }
public DateTime? NgayTao { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public me_DM_MACAddress()
        {
        }
    }
}


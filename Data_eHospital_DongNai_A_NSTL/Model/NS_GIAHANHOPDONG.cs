namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_GIAHANHOPDONG : BaseModel
    {
        [Key]
        public int? id { get; set; }
public string? Mahopdong { get; set; }
public DateTime? GiahanTungay { get; set; }
public DateTime? GiahanDenngay { get; set; }
public string? Solangiahan { get; set; }

        public NS_GIAHANHOPDONG()
        {
        }
    }
}


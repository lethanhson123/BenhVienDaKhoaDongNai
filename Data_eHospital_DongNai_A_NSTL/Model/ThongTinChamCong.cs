namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class ThongTinChamCong : BaseModel
    {
        [Key]
        public int? Id { get; set; }
public string? username { get; set; }
public string? starttime { get; set; }
public string? endtime { get; set; }
public int? deptid { get; set; }
public string? inscopetim { get; set; }
public DateTime? attdate { get; set; }

        public ThongTinChamCong()
        {
        }
    }
}


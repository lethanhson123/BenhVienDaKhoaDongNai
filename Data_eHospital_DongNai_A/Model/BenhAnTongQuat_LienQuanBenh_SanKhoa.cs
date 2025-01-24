namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnTongQuat_LienQuanBenh_SanKhoa : BaseModel
    {
        [Key]
        public long? BenhAnTongQuat_LienQuanBenh_Id { get; set; }
public int? BenhAnTongQuat_Id { get; set; }
public int? SoLanCoThai { get; set; }
public int? Nam { get; set; }
public bool? DuThang { get; set; }
public bool? ThieuThang { get; set; }
public bool? Say { get; set; }
public bool? Hut { get; set; }
public bool? Nao { get; set; }
public string? CoVAC { get; set; }
public string? ChuaNgoaiTC { get; set; }
public string? ChuaTrung { get; set; }
public string? ThaiChetLuu { get; set; }
public int? ConHienSong { get; set; }
public decimal? CanNang { get; set; }
public string? PhuongPhapDe { get; set; }
public string? TaiBien { get; set; }

        public BenhAnTongQuat_LienQuanBenh_SanKhoa()
        {
        }
    }
}


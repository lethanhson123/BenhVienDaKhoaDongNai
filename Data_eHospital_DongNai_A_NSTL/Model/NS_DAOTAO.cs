namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DAOTAO : BaseModel
    {
        [Key]
        public string? Masodaotao { get; set; }
public string? Manhanvien { get; set; }
public string? Chiphicongtytra { get; set; }
public string? Chiphicanhantra { get; set; }
public string? Danhgia { get; set; }
public string? Dutru1 { get; set; }
public string? Dutru2 { get; set; }
public string? Dutru3 { get; set; }
public string? Dutru4 { get; set; }
public string? Dutru5 { get; set; }
public string? KetQua { get; set; }
public float? SoBuoiDiHoc { get; set; }
public int? LoaiDiHoc_Id { get; set; }

        public NS_DAOTAO()
        {
        }
    }
}


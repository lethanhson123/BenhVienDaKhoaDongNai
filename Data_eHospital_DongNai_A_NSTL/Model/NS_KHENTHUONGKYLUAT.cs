namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_KHENTHUONGKYLUAT : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaNhanVien { get; set; }
public string? KTKL { get; set; }
public DateTime? NgayKTKL { get; set; }
public string? NoiDungKTKL { get; set; }
public string? LoaiKTKL { get; set; }
public string? QuyetdinhKTKL { get; set; }

        public NS_KHENTHUONGKYLUAT()
        {
        }
    }
}


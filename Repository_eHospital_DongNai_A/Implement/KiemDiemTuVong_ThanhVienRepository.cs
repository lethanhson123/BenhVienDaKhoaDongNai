namespace Repository_eHospital_DongNai_A.Implement
{
    public class KiemDiemTuVong_ThanhVienRepository : BaseRepository<KiemDiemTuVong_ThanhVien>
    , IKiemDiemTuVong_ThanhVienRepository
    {
    private readonly Context _context;
    public KiemDiemTuVong_ThanhVienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


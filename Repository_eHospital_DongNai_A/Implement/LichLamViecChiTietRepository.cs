namespace Repository_eHospital_DongNai_A.Implement
{
    public class LichLamViecChiTietRepository : BaseRepository<LichLamViecChiTiet>
    , ILichLamViecChiTietRepository
    {
    private readonly Context _context;
    public LichLamViecChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


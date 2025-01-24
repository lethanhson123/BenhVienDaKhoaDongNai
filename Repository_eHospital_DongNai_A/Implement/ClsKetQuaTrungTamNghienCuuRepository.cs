namespace Repository_eHospital_DongNai_A.Implement
{
    public class ClsKetQuaTrungTamNghienCuuRepository : BaseRepository<ClsKetQuaTrungTamNghienCuu>
    , IClsKetQuaTrungTamNghienCuuRepository
    {
    private readonly Context _context;
    public ClsKetQuaTrungTamNghienCuuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


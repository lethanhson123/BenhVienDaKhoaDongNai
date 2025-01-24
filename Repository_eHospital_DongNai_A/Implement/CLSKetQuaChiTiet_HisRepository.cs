namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaChiTiet_HisRepository : BaseRepository<CLSKetQuaChiTiet_His>
    , ICLSKetQuaChiTiet_HisRepository
    {
    private readonly Context _context;
    public CLSKetQuaChiTiet_HisRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


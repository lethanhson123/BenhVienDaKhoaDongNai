namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaChiTiet_VersionRepository : BaseRepository<CLSKetQuaChiTiet_Version>
    , ICLSKetQuaChiTiet_VersionRepository
    {
    private readonly Context _context;
    public CLSKetQuaChiTiet_VersionRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


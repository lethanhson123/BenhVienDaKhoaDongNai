namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSKetQua_VersionRepository : BaseRepository<CLSKetQua_Version>
    , ICLSKetQua_VersionRepository
    {
    private readonly Context _context;
    public CLSKetQua_VersionRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


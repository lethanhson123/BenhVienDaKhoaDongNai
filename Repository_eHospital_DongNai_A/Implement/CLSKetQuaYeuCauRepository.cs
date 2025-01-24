namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaYeuCauRepository : BaseRepository<CLSKetQuaYeuCau>
    , ICLSKetQuaYeuCauRepository
    {
    private readonly Context _context;
    public CLSKetQuaYeuCauRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaXNHuyet_TuyDoRepository : BaseRepository<CLSKetQuaXNHuyet_TuyDo>
    , ICLSKetQuaXNHuyet_TuyDoRepository
    {
    private readonly Context _context;
    public CLSKetQuaXNHuyet_TuyDoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


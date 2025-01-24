namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaXNHuyet_TuyDo_ChiTietRepository : BaseRepository<CLSKetQuaXNHuyet_TuyDo_ChiTiet>
    , ICLSKetQuaXNHuyet_TuyDo_ChiTietRepository
    {
    private readonly Context _context;
    public CLSKetQuaXNHuyet_TuyDo_ChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


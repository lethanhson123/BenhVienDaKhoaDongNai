namespace Repository_eHospital_DongNai_A.Implement
{
    public class LIS_Tmp_CLSKetQuaChiTietRepository : BaseRepository<LIS_Tmp_CLSKetQuaChiTiet>
    , ILIS_Tmp_CLSKetQuaChiTietRepository
    {
    private readonly Context _context;
    public LIS_Tmp_CLSKetQuaChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


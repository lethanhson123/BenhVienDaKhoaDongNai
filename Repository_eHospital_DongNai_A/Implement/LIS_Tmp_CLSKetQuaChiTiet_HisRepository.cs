namespace Repository_eHospital_DongNai_A.Implement
{
    public class LIS_Tmp_CLSKetQuaChiTiet_HisRepository : BaseRepository<LIS_Tmp_CLSKetQuaChiTiet_His>
    , ILIS_Tmp_CLSKetQuaChiTiet_HisRepository
    {
    private readonly Context _context;
    public LIS_Tmp_CLSKetQuaChiTiet_HisRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


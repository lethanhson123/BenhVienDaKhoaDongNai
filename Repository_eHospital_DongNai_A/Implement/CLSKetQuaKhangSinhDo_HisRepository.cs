namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaKhangSinhDo_HisRepository : BaseRepository<CLSKetQuaKhangSinhDo_His>
    , ICLSKetQuaKhangSinhDo_HisRepository
    {
    private readonly Context _context;
    public CLSKetQuaKhangSinhDo_HisRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_SoKhamBenhRepository : BaseRepository<ztmp_SoKhamBenh>
    , Iztmp_SoKhamBenhRepository
    {
    private readonly Context _context;
    public ztmp_SoKhamBenhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


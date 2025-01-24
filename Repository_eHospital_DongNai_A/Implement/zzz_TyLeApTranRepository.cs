namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_TyLeApTranRepository : BaseRepository<zzz_TyLeApTran>
    , Izzz_TyLeApTranRepository
    {
    private readonly Context _context;
    public zzz_TyLeApTranRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


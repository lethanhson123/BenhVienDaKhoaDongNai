namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzz_SoChungTu_TempRepository : BaseRepository<zzzz_SoChungTu_Temp>
    , Izzzz_SoChungTu_TempRepository
    {
    private readonly Context _context;
    public zzzz_SoChungTu_TempRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


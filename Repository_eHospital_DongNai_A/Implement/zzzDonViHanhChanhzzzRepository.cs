namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzDonViHanhChanhzzzRepository : BaseRepository<zzzDonViHanhChanhzzz>
    , IzzzDonViHanhChanhzzzRepository
    {
    private readonly Context _context;
    public zzzDonViHanhChanhzzzRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


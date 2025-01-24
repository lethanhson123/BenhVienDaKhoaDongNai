namespace Repository_eHospital_DongNai_A.Implement
{
    public class MauTinSMSRepository : BaseRepository<MauTinSMS>
    , IMauTinSMSRepository
    {
    private readonly Context _context;
    public MauTinSMSRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


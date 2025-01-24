namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSYeuCauBarCodeRepository : BaseRepository<CLSYeuCauBarCode>
    , ICLSYeuCauBarCodeRepository
    {
    private readonly Context _context;
    public CLSYeuCauBarCodeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class TransferRepository : BaseRepository<Transfer>
    , ITransferRepository
    {
    private readonly Context _context;
    public TransferRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


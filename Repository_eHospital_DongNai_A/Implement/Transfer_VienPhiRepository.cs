namespace Repository_eHospital_DongNai_A.Implement
{
    public class Transfer_VienPhiRepository : BaseRepository<Transfer_VienPhi>
    , ITransfer_VienPhiRepository
    {
    private readonly Context _context;
    public Transfer_VienPhiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


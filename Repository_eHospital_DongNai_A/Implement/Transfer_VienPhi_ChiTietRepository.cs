namespace Repository_eHospital_DongNai_A.Implement
{
    public class Transfer_VienPhi_ChiTietRepository : BaseRepository<Transfer_VienPhi_ChiTiet>
    , ITransfer_VienPhi_ChiTietRepository
    {
    private readonly Context _context;
    public Transfer_VienPhi_ChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


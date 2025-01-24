namespace Repository_eHospital_DongNai_A.Implement
{
    public class Transfer_VienPhi_ChiTiet_TempRepository : BaseRepository<Transfer_VienPhi_ChiTiet_Temp>
    , ITransfer_VienPhi_ChiTiet_TempRepository
    {
    private readonly Context _context;
    public Transfer_VienPhi_ChiTiet_TempRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


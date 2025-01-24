namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChayThanNhanTao_ChiTietRepository : BaseRepository<ChayThanNhanTao_ChiTiet>
    , IChayThanNhanTao_ChiTietRepository
    {
    private readonly Context _context;
    public ChayThanNhanTao_ChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


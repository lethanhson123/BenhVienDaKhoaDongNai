namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChungTu_UNC_ChiTietRepository : BaseRepository<ChungTu_UNC_ChiTiet>
    , IChungTu_UNC_ChiTietRepository
    {
    private readonly Context _context;
    public ChungTu_UNC_ChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


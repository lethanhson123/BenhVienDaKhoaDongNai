namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThucHienCheckListChiTietRepository : BaseRepository<ThucHienCheckListChiTiet>
    , IThucHienCheckListChiTietRepository
    {
    private readonly Context _context;
    public ThucHienCheckListChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamSucKhoeChiTietRepository : BaseRepository<KhamSucKhoeChiTiet>
    , IKhamSucKhoeChiTietRepository
    {
    private readonly Context _context;
    public KhamSucKhoeChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


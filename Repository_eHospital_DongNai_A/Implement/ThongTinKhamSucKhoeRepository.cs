namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThongTinKhamSucKhoeRepository : BaseRepository<ThongTinKhamSucKhoe>
    , IThongTinKhamSucKhoeRepository
    {
    private readonly Context _context;
    public ThongTinKhamSucKhoeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


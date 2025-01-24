namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_SuDungPhongChoRepository : BaseRepository<CSKH_The_SuDungPhongCho>
    , ICSKH_The_SuDungPhongChoRepository
    {
    private readonly Context _context;
    public CSKH_The_SuDungPhongChoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


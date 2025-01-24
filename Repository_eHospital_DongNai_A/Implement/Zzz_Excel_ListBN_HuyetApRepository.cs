namespace Repository_eHospital_DongNai_A.Implement
{
    public class Zzz_Excel_ListBN_HuyetApRepository : BaseRepository<Zzz_Excel_ListBN_HuyetAp>
    , IZzz_Excel_ListBN_HuyetApRepository
    {
    private readonly Context _context;
    public Zzz_Excel_ListBN_HuyetApRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


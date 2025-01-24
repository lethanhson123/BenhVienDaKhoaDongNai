namespace Repository_eHospital_DongNai_A.Implement
{
    public class cus_HDDTRepository : BaseRepository<cus_HDDT>
    , Icus_HDDTRepository
    {
    private readonly Context _context;
    public cus_HDDTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


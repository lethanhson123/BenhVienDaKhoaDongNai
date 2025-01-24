namespace Repository_eHospital_DongNai_A.Implement
{
    public class RIS_MESSAGES_SENDRepository : BaseRepository<RIS_MESSAGES_SEND>
    , IRIS_MESSAGES_SENDRepository
    {
    private readonly Context _context;
    public RIS_MESSAGES_SENDRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


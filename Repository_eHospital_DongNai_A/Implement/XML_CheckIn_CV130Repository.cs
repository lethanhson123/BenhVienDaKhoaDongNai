namespace Repository_eHospital_DongNai_A.Implement
{
    public class XML_CheckIn_CV130Repository : BaseRepository<XML_CheckIn_CV130>
    , IXML_CheckIn_CV130Repository
    {
    private readonly Context _context;
    public XML_CheckIn_CV130Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


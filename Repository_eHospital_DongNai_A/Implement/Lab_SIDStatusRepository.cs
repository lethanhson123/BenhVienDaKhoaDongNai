namespace Repository_eHospital_DongNai_A.Implement
{
    public class Lab_SIDStatusRepository : BaseRepository<Lab_SIDStatus>
    , ILab_SIDStatusRepository
    {
    private readonly Context _context;
    public Lab_SIDStatusRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


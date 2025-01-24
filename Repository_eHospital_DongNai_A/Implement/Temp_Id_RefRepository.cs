namespace Repository_eHospital_DongNai_A.Implement
{
    public class Temp_Id_RefRepository : BaseRepository<Temp_Id_Ref>
    , ITemp_Id_RefRepository
    {
    private readonly Context _context;
    public Temp_Id_RefRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


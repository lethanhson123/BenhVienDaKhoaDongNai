namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class Lst_Dictionary_TypeRepository : BaseRepository<Lst_Dictionary_Type>
    , ILst_Dictionary_TypeRepository
    {
    private readonly Context _context;
    public Lst_Dictionary_TypeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


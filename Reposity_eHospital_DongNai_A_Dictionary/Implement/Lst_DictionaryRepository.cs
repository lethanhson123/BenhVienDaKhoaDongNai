namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class Lst_DictionaryRepository : BaseRepository<Lst_Dictionary>
    , ILst_DictionaryRepository
    {
    private readonly Context _context;
    public Lst_DictionaryRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


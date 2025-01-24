namespace Repository_eHospital_DongNai_A.Implement
{
    public class CUS_ProductsRepository : BaseRepository<CUS_Products>
    , ICUS_ProductsRepository
    {
    private readonly Context _context;
    public CUS_ProductsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


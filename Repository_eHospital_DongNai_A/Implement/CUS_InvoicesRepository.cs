namespace Repository_eHospital_DongNai_A.Implement
{
    public class CUS_InvoicesRepository : BaseRepository<CUS_Invoices>
    , ICUS_InvoicesRepository
    {
    private readonly Context _context;
    public CUS_InvoicesRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


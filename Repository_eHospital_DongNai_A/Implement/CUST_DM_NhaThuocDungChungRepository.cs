namespace Repository_eHospital_DongNai_A.Implement
{
    public class CUST_DM_NhaThuocDungChungRepository : BaseRepository<CUST_DM_NhaThuocDungChung>
    , ICUST_DM_NhaThuocDungChungRepository
    {
    private readonly Context _context;
    public CUST_DM_NhaThuocDungChungRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


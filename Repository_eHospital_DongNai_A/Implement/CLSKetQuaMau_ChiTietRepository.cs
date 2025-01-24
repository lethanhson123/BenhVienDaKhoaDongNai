namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaMau_ChiTietRepository : BaseRepository<CLSKetQuaMau_ChiTiet>
    , ICLSKetQuaMau_ChiTietRepository
    {
    private readonly Context _context;
    public CLSKetQuaMau_ChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


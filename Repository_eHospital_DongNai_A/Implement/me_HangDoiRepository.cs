namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_HangDoiRepository : BaseRepository<me_HangDoi>
    , Ime_HangDoiRepository
    {
    private readonly Context _context;
    public me_HangDoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


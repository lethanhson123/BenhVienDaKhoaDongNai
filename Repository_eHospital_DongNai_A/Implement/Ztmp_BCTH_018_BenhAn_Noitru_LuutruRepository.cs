namespace Repository_eHospital_DongNai_A.Implement
{
    public class Ztmp_BCTH_018_BenhAn_Noitru_LuutruRepository : BaseRepository<Ztmp_BCTH_018_BenhAn_Noitru_Luutru>
    , IZtmp_BCTH_018_BenhAn_Noitru_LuutruRepository
    {
    private readonly Context _context;
    public Ztmp_BCTH_018_BenhAn_Noitru_LuutruRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuat_ImagesRepository : BaseRepository<BenhAnPhauThuat_Images>
    , IBenhAnPhauThuat_ImagesRepository
    {
    private readonly Context _context;
    public BenhAnPhauThuat_ImagesRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


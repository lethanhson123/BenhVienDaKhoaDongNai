namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_VitriCuaTrenFormRepository : BaseRepository<me_VitriCuaTrenForm>
    , Ime_VitriCuaTrenFormRepository
    {
    private readonly Context _context;
    public me_VitriCuaTrenFormRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }


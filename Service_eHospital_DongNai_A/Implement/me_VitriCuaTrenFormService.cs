namespace Service_eHospital_DongNai_A.Implement
{
    public class me_VitriCuaTrenFormService : BaseService<me_VitriCuaTrenForm, Ime_VitriCuaTrenFormRepository>
    , Ime_VitriCuaTrenFormService
    {
    private readonly Ime_VitriCuaTrenFormRepository _me_VitriCuaTrenFormRepository;
    public me_VitriCuaTrenFormService(Ime_VitriCuaTrenFormRepository me_VitriCuaTrenFormRepository) : base(me_VitriCuaTrenFormRepository)
    {
    _me_VitriCuaTrenFormRepository = me_VitriCuaTrenFormRepository;
    }
    }
    }


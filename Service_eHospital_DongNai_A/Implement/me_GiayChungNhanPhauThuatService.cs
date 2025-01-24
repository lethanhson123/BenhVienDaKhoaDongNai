namespace Service_eHospital_DongNai_A.Implement
{
    public class me_GiayChungNhanPhauThuatService : BaseService<me_GiayChungNhanPhauThuat, Ime_GiayChungNhanPhauThuatRepository>
    , Ime_GiayChungNhanPhauThuatService
    {
    private readonly Ime_GiayChungNhanPhauThuatRepository _me_GiayChungNhanPhauThuatRepository;
    public me_GiayChungNhanPhauThuatService(Ime_GiayChungNhanPhauThuatRepository me_GiayChungNhanPhauThuatRepository) : base(me_GiayChungNhanPhauThuatRepository)
    {
    _me_GiayChungNhanPhauThuatRepository = me_GiayChungNhanPhauThuatRepository;
    }
    }
    }


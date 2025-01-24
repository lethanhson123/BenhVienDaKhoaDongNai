namespace Service_eHospital_DongNai_A.Implement
{
    public class Ztmp_BCTH_018_BenhAn_Noitru_LuutruService : BaseService<Ztmp_BCTH_018_BenhAn_Noitru_Luutru, IZtmp_BCTH_018_BenhAn_Noitru_LuutruRepository>
    , IZtmp_BCTH_018_BenhAn_Noitru_LuutruService
    {
    private readonly IZtmp_BCTH_018_BenhAn_Noitru_LuutruRepository _Ztmp_BCTH_018_BenhAn_Noitru_LuutruRepository;
    public Ztmp_BCTH_018_BenhAn_Noitru_LuutruService(IZtmp_BCTH_018_BenhAn_Noitru_LuutruRepository Ztmp_BCTH_018_BenhAn_Noitru_LuutruRepository) : base(Ztmp_BCTH_018_BenhAn_Noitru_LuutruRepository)
    {
    _Ztmp_BCTH_018_BenhAn_Noitru_LuutruRepository = Ztmp_BCTH_018_BenhAn_Noitru_LuutruRepository;
    }
    }
    }


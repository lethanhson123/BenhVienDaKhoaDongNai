namespace Service_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_SoThuTuTiepNhanService : BaseService<Lst_KeyData_SoThuTuTiepNhan, ILst_KeyData_SoThuTuTiepNhanRepository>
    , ILst_KeyData_SoThuTuTiepNhanService
    {
    private readonly ILst_KeyData_SoThuTuTiepNhanRepository _Lst_KeyData_SoThuTuTiepNhanRepository;
    public Lst_KeyData_SoThuTuTiepNhanService(ILst_KeyData_SoThuTuTiepNhanRepository Lst_KeyData_SoThuTuTiepNhanRepository) : base(Lst_KeyData_SoThuTuTiepNhanRepository)
    {
    _Lst_KeyData_SoThuTuTiepNhanRepository = Lst_KeyData_SoThuTuTiepNhanRepository;
    }
    }
    }


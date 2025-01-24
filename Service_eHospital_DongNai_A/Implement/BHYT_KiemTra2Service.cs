namespace Service_eHospital_DongNai_A.Implement
{
    public class BHYT_KiemTra2Service : BaseService<BHYT_KiemTra2, IBHYT_KiemTra2Repository>
    , IBHYT_KiemTra2Service
    {
    private readonly IBHYT_KiemTra2Repository _BHYT_KiemTra2Repository;
    public BHYT_KiemTra2Service(IBHYT_KiemTra2Repository BHYT_KiemTra2Repository) : base(BHYT_KiemTra2Repository)
    {
    _BHYT_KiemTra2Repository = BHYT_KiemTra2Repository;
    }
    }
    }


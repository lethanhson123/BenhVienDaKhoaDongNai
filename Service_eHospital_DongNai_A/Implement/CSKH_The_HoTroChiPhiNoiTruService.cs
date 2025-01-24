namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_HoTroChiPhiNoiTruService : BaseService<CSKH_The_HoTroChiPhiNoiTru, ICSKH_The_HoTroChiPhiNoiTruRepository>
    , ICSKH_The_HoTroChiPhiNoiTruService
    {
    private readonly ICSKH_The_HoTroChiPhiNoiTruRepository _CSKH_The_HoTroChiPhiNoiTruRepository;
    public CSKH_The_HoTroChiPhiNoiTruService(ICSKH_The_HoTroChiPhiNoiTruRepository CSKH_The_HoTroChiPhiNoiTruRepository) : base(CSKH_The_HoTroChiPhiNoiTruRepository)
    {
    _CSKH_The_HoTroChiPhiNoiTruRepository = CSKH_The_HoTroChiPhiNoiTruRepository;
    }
    }
    }


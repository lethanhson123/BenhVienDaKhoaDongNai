namespace Service_eHospital_DongNai_A.Implement
{
    public class PhieuChanDoanHoaMoMienDichService : BaseService<PhieuChanDoanHoaMoMienDich, IPhieuChanDoanHoaMoMienDichRepository>
    , IPhieuChanDoanHoaMoMienDichService
    {
    private readonly IPhieuChanDoanHoaMoMienDichRepository _PhieuChanDoanHoaMoMienDichRepository;
    public PhieuChanDoanHoaMoMienDichService(IPhieuChanDoanHoaMoMienDichRepository PhieuChanDoanHoaMoMienDichRepository) : base(PhieuChanDoanHoaMoMienDichRepository)
    {
    _PhieuChanDoanHoaMoMienDichRepository = PhieuChanDoanHoaMoMienDichRepository;
    }
    }
    }


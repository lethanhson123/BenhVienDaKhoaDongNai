namespace Service_eHospital_DongNai_A.Implement
{
    public class me_HangDoiService : BaseService<me_HangDoi, Ime_HangDoiRepository>
    , Ime_HangDoiService
    {
    private readonly Ime_HangDoiRepository _me_HangDoiRepository;
    public me_HangDoiService(Ime_HangDoiRepository me_HangDoiRepository) : base(me_HangDoiRepository)
    {
    _me_HangDoiRepository = me_HangDoiRepository;
    }
    }
    }


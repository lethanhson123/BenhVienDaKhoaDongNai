namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_BANGCAP_BK20171228Service : BaseService<NS_BANGCAP_BK20171228, INS_BANGCAP_BK20171228Repository>
    , INS_BANGCAP_BK20171228Service
    {
    private readonly INS_BANGCAP_BK20171228Repository _NS_BANGCAP_BK20171228Repository;
    public NS_BANGCAP_BK20171228Service(INS_BANGCAP_BK20171228Repository NS_BANGCAP_BK20171228Repository) : base(NS_BANGCAP_BK20171228Repository)
    {
    _NS_BANGCAP_BK20171228Repository = NS_BANGCAP_BK20171228Repository;
    }
    }
    }


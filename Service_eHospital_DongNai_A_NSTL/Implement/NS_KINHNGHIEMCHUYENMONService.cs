﻿namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_KINHNGHIEMCHUYENMONService : BaseService<NS_KINHNGHIEMCHUYENMON, INS_KINHNGHIEMCHUYENMONRepository>
    , INS_KINHNGHIEMCHUYENMONService
    {
    private readonly INS_KINHNGHIEMCHUYENMONRepository _NS_KINHNGHIEMCHUYENMONRepository;
    public NS_KINHNGHIEMCHUYENMONService(INS_KINHNGHIEMCHUYENMONRepository NS_KINHNGHIEMCHUYENMONRepository) : base(NS_KINHNGHIEMCHUYENMONRepository)
    {
    _NS_KINHNGHIEMCHUYENMONRepository = NS_KINHNGHIEMCHUYENMONRepository;
    }
    }
    }


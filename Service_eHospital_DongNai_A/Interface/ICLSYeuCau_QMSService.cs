﻿namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSYeuCau_QMSService : IBaseService<CLSYeuCau_QMS>
    {
        Task<List<CLSYeuCau_QMS>> GetByListIDToListAsync(List<int?> ListID);
    }
}


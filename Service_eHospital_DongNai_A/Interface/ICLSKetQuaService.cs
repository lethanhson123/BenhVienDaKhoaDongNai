﻿namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSKetQuaService : IBaseService<CLSKetQua>
    {
        Task<List<CLSKetQua>> GetByListIDToListAsync(List<int?> ListID);
    }
}


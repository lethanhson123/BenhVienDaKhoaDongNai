﻿namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSYeuCauService : BaseService<CLSYeuCau, ICLSYeuCauRepository>
    , ICLSYeuCauService
    {
        private readonly ICLSYeuCauRepository _CLSYeuCauRepository;
        public CLSYeuCauService(ICLSYeuCauRepository CLSYeuCauRepository) : base(CLSYeuCauRepository)
        {
            _CLSYeuCauRepository = CLSYeuCauRepository;
        }
        public virtual async Task<List<CLSYeuCau>> ReportACLSYeuCau0004ToListAsync(string ListCLSYeuCau_Id, int Year, int Month, int Day)
        {
            List<CLSYeuCau> result = new List<CLSYeuCau>();
            try
            {
                SqlParameter[] parameters =
                {                        
                        new SqlParameter("@ListCLSYeuCau_Id",ListCLSYeuCau_Id),
                        new SqlParameter("@Year",Year),
                        new SqlParameter("@Month",Month),
                        new SqlParameter("@Day",Day),
                };
                result = await GetByStoredProcedureToListAsync("sp_ReportACLSYeuCau0004", parameters);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}


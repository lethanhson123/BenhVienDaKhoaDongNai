namespace ServiceReport.Implement
{
    public class ReportService : BaseService<Report>
    , IReportService
    {
      
        public ReportService() : base()
        {            
        }
        public virtual async Task<List<Report>> ReportDictionary0001ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {                
                result = await GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A_Dictionary, "sp_ReportDictionary0001");
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<Report>> ReportDictionary0002ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                result = await GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A_Dictionary, "sp_ReportDictionary0002");
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<Report>> ReportDictionary0003ToListAsync(int Year)
        {
            List<Report> result = new List<Report>();
            try
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@YearInput",Year),
                };
                result = await GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A_Dictionary, "sp_ReportDictionary0003", parameters);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<Report>> ReportDictionary0004ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {               
                result = await GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A_Dictionary, "sp_ReportDictionary0004");
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<Report>> ReportA0001ToListAsync(int Year, int Month, int Day, int PhongBanID)
        {
            List<Report> result = new List<Report>();
            try
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@Year",Year),
                        new SqlParameter("@Month",Month),
                        new SqlParameter("@Day",Day),
                        new SqlParameter("@PhongBanID",PhongBanID),
                };
                result = await GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A, "sp_ReportA0001", parameters);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<Report>> ReportNSTLA0001ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {                
                result = await GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_NewComet_NSTL_A, "sp_ReportNSTLA0001");
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<Report>> ReportNSTLA0002ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                result = await GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_NewComet_NSTL_A, "sp_ReportNSTLA0002");
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}


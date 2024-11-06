using Data.Model;

namespace Service.Implement
{
    public class ReportService : BaseService<Report, IReportRepository>
    , IReportService
    {
        private readonly IReportRepository _ReportRepository;
        public ReportService(IReportRepository ReportRepository) : base(ReportRepository)
        {
            _ReportRepository = ReportRepository;
        }
        public virtual async Task<List<Report>> Report0001ToListAsync(long ID)
        {
            List<Report> result = new List<Report>();
            try
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@ID",ID),
                };
                result = await GetByStoredProcedureToListAsync("sp_Report0001", parameters);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<Report>> Report0002ToListAsync(long ID)
        {
            List<Report> result = new List<Report>();
            try
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@ID",ID),
                };
                result = await GetByStoredProcedureToListAsync("sp_Report0002", parameters);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<Report>> Report0003ToListAsync(long ID)
        {
            List<Report> result = new List<Report>();
            try
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@ID",ID),
                };
                result = await GetByStoredProcedureToListAsync("sp_Report0003", parameters);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<Report> Report0004ToAsync(long ThanhVienID)
        {
            Report result = new Report();
            try
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@ThanhVienID",ThanhVienID),
                };
                List<Report> list = await GetByStoredProcedureToListAsync("sp_Report0004", parameters);
                if (list.Count > 0)
                {
                    result = list[0];
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<Report>> Report0005ToListAsync(long ThanhVienID)
        {
            List<Report> result = new List<Report>();
            try
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@ThanhVienID",ThanhVienID),
                };
                result = await GetByStoredProcedureToListAsync("sp_Report0005", parameters);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}


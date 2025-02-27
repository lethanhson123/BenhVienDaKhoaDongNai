namespace ServiceReport
{
    public class BaseService<T> : ServiceReport.Interface.IBaseService<T>
        where T : class       
    {        
        public BaseService()
        {
            
        }
       
        public virtual List<T> GetByStoredProcedureToList(string ConnectionString, string storedProcedureName, params SqlParameter[] parameters)
        {
            List<T> result = new List<T>();
            try
            {
                DataTable dt = SQLHelper.FillDataTable(ConnectionString, storedProcedureName, parameters);
                result = SQLHelper.ToList<T>(dt);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<T>> GetByStoredProcedureToListAsync(string ConnectionString, string storedProcedureName, params SqlParameter[] parameters)
        {
            List<T> result = new List<T>();
            try
            {
                DataTable dt = await SQLHelper.FillDataTableAsync(ConnectionString, storedProcedureName, parameters);
                result = SQLHelper.ToList<T>(dt);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }    
    }
}

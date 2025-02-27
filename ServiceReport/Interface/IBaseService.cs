namespace ServiceReport.Interface
{
    public interface IBaseService<T>
        where T : class
    {        
        List<T> GetByStoredProcedureToList(string ConnectionString, string storedProcedureName, params SqlParameter[] parameters);
        Task<List<T>> GetByStoredProcedureToListAsync(string ConnectionString, string storedProcedureName, params SqlParameter[] parameters);      

    }
}

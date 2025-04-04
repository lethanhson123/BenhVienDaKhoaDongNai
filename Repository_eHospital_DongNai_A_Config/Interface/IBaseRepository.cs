﻿namespace Repository_eHospital_DongNai_A_Config.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        DbSet<T> DbSet();
        int Add(T model);
        Task<int> AddAsync(T model);
        int Update(T model);
        Task<int> UpdateAsync(T model);
        int Remove(T model);
        Task<int> RemoveAsync(T model);        
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> whereCondition);
        List<T> GetAllToList();
        Task<List<T>> GetAllToListAsync();
        List<T> GetBySearchStringToList(string searchString);
        Task<List<T>> GetBySearchStringToListAsync(string searchString);
        List<T> GetByPageAndPageSizeToList(int page, int pageSize);
        Task<List<T>> GetByPageAndPageSizeToListAsync(int page, int pageSize);        
        string ExecuteNonQueryByStoredProcedure(string storedProcedureName, params SqlParameter[] parameters);
        Task<string> ExecuteNonQueryByStoredProcedureAsync(string storedProcedureName, params SqlParameter[] parameters);
        List<T> GetByStoredProcedureToList(string storedProcedureName, params SqlParameter[] parameters);
        Task<List<T>> GetByStoredProcedureToListAsync(string storedProcedureName, params SqlParameter[] parameters);
    }
}

﻿namespace Repository_eHospital_DongNai_A.Implement
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }
        public virtual DbSet<T> DbSet()
        {
            return _context.Set<T>();
        }
        public virtual void Initialization(T model)
        {
        }
        public virtual int Add(T model)
        {
            int result = 0;
            try
            {
                Initialization(model);
                _context.Set<T>().Add(model);
                result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<int> AddAsync(T model)
        {
            int result = 0;
            try
            {
                Initialization(model);
                _context.Set<T>().Add(model);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual int Update(T model)
        {
            int result = 0;
            try
            {
                _context.Set<T>().Update(model);
                result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<int> UpdateAsync(T model)
        {
            int result = 0;
            try
            {
                _context.Set<T>().Update(model);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual int Remove(T model)
        {
            int result = 0;
            try
            {
                _context.Set<T>().Remove(model);
                result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<int> RemoveAsync(T model)
        {
            int result = 0;
            try
            {
                _context.Set<T>().Remove(model);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }       
        public virtual IQueryable<T> GetByCondition(Expression<Func<T, bool>> whereCondition)
        {
            var result = _context.Set<T>().AsNoTracking().Where(whereCondition);
            return result;
        }

        public virtual List<T> GetAllToList()
        {
            var result = _context.Set<T>().AsNoTracking().ToList();
            return result ?? new List<T>();
        }
        public virtual async Task<List<T>> GetAllToListAsync()
        {
            var result = await _context.Set<T>().AsNoTracking().ToListAsync();
            return result ?? new List<T>();
        }

        public virtual List<T> GetBySearchStringToList(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                return _context.Set<T>().AsNoTracking().Where(item => 1 == 1).ToList();
            }
            else
            {
                return new List<T>();
            }
        }
        public virtual async Task<List<T>> GetBySearchStringToListAsync(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                return await _context.Set<T>().AsNoTracking().Where(item => 1 == 1).ToListAsync();
            }
            else
            {
                return new List<T>();
            }
        }
        public virtual List<T> GetByPageAndPageSizeToList(int page, int pageSize)
        {
            var result = _context.Set<T>().AsNoTracking().Skip(page * pageSize).Take(pageSize).ToList();
            return result;
        }
        public virtual async Task<List<T>> GetByPageAndPageSizeToListAsync(int page, int pageSize)
        {
            var result = await _context.Set<T>().AsNoTracking().Skip(page * pageSize).Take(pageSize).ToListAsync();
            return result;
        }
       
        public virtual string ExecuteNonQueryByStoredProcedure(string storedProcedureName, params SqlParameter[] parameters)
        {
            var result = GlobalHelper.InitializationString;
            try
            {
                result = SQLHelper.ExecuteNonQuery(_context.Database.GetConnectionString(), storedProcedureName, parameters);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        public virtual async Task<string> ExecuteNonQueryByStoredProcedureAsync(string storedProcedureName, params SqlParameter[] parameters)
        {
            var result = GlobalHelper.InitializationString;
            try
            {
                result = await SQLHelper.ExecuteNonQueryAsync(_context.Database.GetConnectionString(), storedProcedureName, parameters);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        public virtual List<T> GetByStoredProcedureToList(string storedProcedureName, params SqlParameter[] parameters)
        {
            List<T> result = new List<T>();
            try
            {
                DataTable dt = SQLHelper.FillDataTable(_context.Database.GetConnectionString(), storedProcedureName, parameters);
                result = SQLHelper.ToList<T>(dt);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<T>> GetByStoredProcedureToListAsync(string storedProcedureName, params SqlParameter[] parameters)
        {
            List<T> result = new List<T>();
            try
            {
                string GetConnectionString=_context.Database.GetConnectionString();
                DataTable dt = await SQLHelper.FillDataTableAsync(_context.Database.GetConnectionString(), storedProcedureName, parameters);
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

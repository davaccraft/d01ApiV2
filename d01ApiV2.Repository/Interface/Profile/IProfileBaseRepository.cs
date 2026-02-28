using d01ApiV2.Model;
using d01ApiV2.Model.Request;

namespace d01ApiV2.Repository.Interface.Profile
{
    public interface IProfileBaseRepository
    {
        /// <summary>
        /// Get List of data via pagination
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<ApiResponse<T>> Paginate<T>(RequestKeyValue request);

        /// <summary>
        /// Get List of data usually for list/dropdown
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<ApiResponse<T>> GetList<T>(RequestKeyValue request);

        /// <summary>
        /// Get single set of data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<ApiResponse<T>> Get<T>(RequestKeyValue request);

        /// <summary>
        /// Save data (insert, update and soft delete)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<ApiResponse<T>> Save<T>(RequestKeyValue request);

        /// <summary>
        /// Save data as soft delete)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<ApiResponse<T>> Delete<T>(RequestKeyValue request);

        /// <summary>
        /// Delete data from database - should not be apply to most of table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<ApiResponse<T>> HardDelete<T>(RequestKeyValue request);
    }
}

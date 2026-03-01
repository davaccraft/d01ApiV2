using d01ApiV2.Model;
using d01ApiV2.Model.Request;

namespace d01ApiV2.Repository.Interface.Shared
{
    public interface ISharedRepository
    {
        Task<ApiResponse<T>> GetMenuList<T>(RequestKeyValue request);
        Task<ApiResponse<T>> GetPageComponents<T>(RequestKeyValue request);
        Task<ApiResponse<T>> GetAdvanceSearchComponents<T>(RequestKeyValue request);
    }
}

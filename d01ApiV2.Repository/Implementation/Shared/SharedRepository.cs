using d01ApiV2.Common.Constant;
using d01ApiV2.DbFactory.Interface;
using d01ApiV2.Model;
using d01ApiV2.Model.Component;
using d01ApiV2.Model.Module;
using d01ApiV2.Model.Request;
using d01ApiV2.Repository.Interface.Shared;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace d01ApiV2.Repository.Implementation.Shared
{
    public class SharedRepository : ISharedRepository
    {
        private readonly IAppDbFactory _appDbFactory;

        public SharedRepository(IAppDbFactory appDbFactory)
        {
            _appDbFactory = appDbFactory;
        }

        public async Task<ApiResponse<T>> GetMenuList<T>(RequestKeyValue request)
        {
            var dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            foreach (var entry in request.Parameters)
            {
                dt.Rows.Add(entry.Key, entry.Value);
            }

            var parameter = new
            {
                Parameter = dt.AsTableValuedParameter("dbo.UDTTParameter")
            };

            var result = await _appDbFactory.ExecuteQueryMultipleReturnAsync<DbReturnModuleGroupAndModule, DbReturnInfo>(StoredProcedure.GetModuleGroupsAndModules, parameter).ConfigureAwait(false);

            var data = result.Item1.ToList()
                .GroupBy(f => new
                {
                    f.ModuleTypeOrderNo,
                    f.ModuleTypeCode,
                    f.ModuleTypeCaption,
                    f.ModuleTypeDescription,
                    f.ModuleTypeIcon
                })
                .Select(g => new ResponseModuleGroup
                {
                    ModuleGroupNo = g.Key.ModuleTypeOrderNo,
                    ModuleGroupCode = g.Key.ModuleTypeCode,
                    ModuleGroupCaption = g.Key.ModuleTypeCaption,
                    ModuleGroupIcon = g.Key.ModuleTypeIcon,
                    ModuleGroupModules = g.Select(m => new ResponseModule
                    {
                        OrderNo = m.ModuleOrderNo,
                        Code = m.ModuleCode,
                        Caption = m.ModuleCaption,
                        Icon = m.Icon,
                        IsEnabled = m.IsEnabled,
                        IsReadOnly = m.IsReadOnly
                    }).OrderBy(m => m.Code).ToList() // Optional: Sort modules
                }).ToList();


            ApiResponse<List<ResponseModuleGroup>> resultData = new ApiResponse<List<ResponseModuleGroup>>
            {
                Data = data,
                ReturnCode = result.Item2.ReturnCode,
                ReturnMessage = result.Item2.ReturnMessage
            };

            return (ApiResponse<T>)(object)resultData;
        }

        public async Task<ApiResponse<T>> GetPageComponents<T>(RequestKeyValue request)
        {
            var dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            foreach (var entry in request.Parameters)
            {
                dt.Rows.Add(entry.Key, entry.Value);
            }

            var parameter = new
            {
                Parameter = dt.AsTableValuedParameter("dbo.UDTTParameter")
            };

            var result = await _appDbFactory.ExecuteQueryMultipleReturnAsync<DbReturnComponent, DbReturnInfo>(StoredProcedure.GetPageComponents, parameter).ConfigureAwait(false);

            var data = result.Item1.ToList()
                .Select(c => new ResponseComponent
                {
                    DisplayOrderNo = c.DisplayOrderNo,
                    InternalCode = c.InternalCode,
                    Caption = c.Caption,
                    Placeholder = c.Placeholder,
                    DataType = c.DataType,
                    DataFormat = c.DataFormat,
                    ComponentType = c.ComponentType,
                    MethodCode = c.MethodCode,
                    IsVisible = c.IsVisible,
                    IsReadOnly = c.IsReadOnly,
                    IsEnable = c.IsEnable
                }).ToList();

            ApiResponse<ResponseDataComponents> resultData = new ApiResponse<ResponseDataComponents>
            {
                Data = new ResponseDataComponents
                {
                    Components = data
                },
                ReturnCode = result.Item2.ReturnCode,
                ReturnMessage = result.Item2.ReturnMessage
            };

            return (ApiResponse<T>)(object)resultData;
        }

        public async Task<ApiResponse<T>> GetAdvanceSearchComponents<T>(RequestKeyValue request)
        {
            var dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            foreach (var entry in request.Parameters)
            {
                dt.Rows.Add(entry.Key, entry.Value);
            }

            var parameter = new
            {
                Parameter = dt.AsTableValuedParameter("dbo.UDTTParameter")
            };

            var result = await _appDbFactory.ExecuteQueryMultipleReturnAsync<DbReturnComponent, DbReturnInfo>(StoredProcedure.GetAdvanceSearchComponents, parameter).ConfigureAwait(false);


            var data = result.Item1.ToList()
               .Select(c => new ResponseComponent
               {
                   DisplayOrderNo = c.DisplayOrderNo,
                   InternalCode = c.InternalCode,
                   Caption = c.Caption,
                   Placeholder = c.Placeholder,
                   DataType = c.DataType,
                   DataFormat = c.DataFormat,
                   ComponentType = c.ComponentType,
                   MethodCode = c.MethodCode,
                   IsVisible = c.IsVisible,
                   IsReadOnly = c.IsReadOnly,
                   IsEnable = c.IsEnable
               }).ToList();

            ApiResponse<ResponseDataComponents> resultData = new ApiResponse<ResponseDataComponents>
            {
                Data = new ResponseDataComponents
                {
                    Components = data
                },
                ReturnCode = result.Item2.ReturnCode,
                ReturnMessage = result.Item2.ReturnMessage
            };

            return (ApiResponse<T>)(object)resultData;
        }
    }
}

using d01ApiV2.Common.Constant;
using d01ApiV2.DbFactory.Interface;
using d01ApiV2.Model;
using d01ApiV2.Model.Component;
using d01ApiV2.Model.Dto;
//using d01ApiV2.Model.Module;
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

        /* removing this code since no longer applicable
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

            var result = await _appDbFactory.ExecuteQueryMultipleReturnAsync<DbReturnModuleGroupAndModule, ResultDto>(StoredProcedure.GetModuleGroupsAndModules, parameter).ConfigureAwait(false);

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

            var result = await _appDbFactory.ExecuteQueryMultipleReturnAsync<ComponentDto, ResultDto>(StoredProcedure.GetPageComponents, parameter).ConfigureAwait(false);

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

            var result = await _appDbFactory.ExecuteQueryMultipleReturnAsync<ComponentDto, ResultDto>(StoredProcedure.GetAdvanceSearchComponents, parameter).ConfigureAwait(false);


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

        //*/

        public async Task<ApiResponse<T>> GetComponents<T>(RequestKeyValue request)
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

            //#1. Menu/Module Components
            //#2. Detail Page Components
            //#3. List Page Components
            //#4. Advance Search Components of List Page
            //#5. Grid Components of List Page
            var result = await _appDbFactory.ExecuteQueryMultipleReturnAsync<ModuleDto, ComponentDto, ComponentDto, ComponentDto, ComponentGridDto, ResultDto>(StoredProcedure.GetComponents, parameter).ConfigureAwait(false);


            var components = result.Item1.ToList()
                .GroupBy(m => new { m.GroupOrderNo, m.GroupCode, m.GroupCaption, m.GroupIcon })
                .Select(g => new ModuleGroupComponent
                {
                    GroupOrderNo = g.Key.GroupOrderNo,
                    GroupCode = g.Key.GroupCode,
                    GroupCaption = g.Key.GroupCaption,
                    GroupIcon = g.Key.GroupIcon ?? "",
                    Modules = g.Select(m => new ModuleComponent
                    {
                        ModuleOrderNo = m.ModuleOrderNo,
                        ModuleCode = m.ModuleCode,
                        ModuleCaption = m.ModuleCaption,
                        ModuleIcon = m.ModuleIcon ?? "",
                        ModuleIsEnabled = m.ModuleIsEnabled,
                        ModuleIsReadOnly = m.ModuleIsReadOnly,

                        DetailPageComponents = result.Item2.ToList()
                            .Where(c => c.ModuleCode == m.ModuleCode)
                            .Select(MapToComponentDto).OrderBy(o => o.DisplayOrderNo).ToList(),

                        ListPageComponents = result.Item3.ToList()
                            .Where(c => c.ModuleCode == m.ModuleCode)
                            .Select(MapToComponentDto).OrderBy(o => o.DisplayOrderNo).ToList(),

                        AdvanceSearchComponents = result.Item4.ToList()
                            .Where(c => c.ModuleCode == m.ModuleCode)
                            .Select(MapToComponentDto).OrderBy(o => o.DisplayOrderNo).ToList(),

                        //ListGridComponents = result.Item5.ToList()
                        //    .Where(c => c.ModuleCode == m.ModuleCode && c.GridPage.ToUpper() == "LIST")
                        //    .Select(MapToComponentGridDto).OrderBy(o => o.DisplayOrderNo).ToList(),

                        //DetailGridComponents = result.Item5.ToList()
                        //    .Where(c => c.ModuleCode == m.ModuleCode && c.GridPage.ToUpper() == "DETAIL")
                        //    .Select(MapToComponentGridDto).OrderBy(o => o.DisplayOrderNo).ToList(),
                        ListGridComponents = result.Item5.ToList()
                            .Where(c => c.ModuleCode == m.ModuleCode && c.GridPage.Equals("LIST", StringComparison.OrdinalIgnoreCase))
                            .GroupBy(c => c.GridOrderNo) // Grouping by GridOrderNo
                            .Select(group => new GridGroupComponent
                            {
                                GridOrderNo = group.Key,
                                Components = group.Select(MapToComponentGridDto)
                                      .OrderBy(o => o.DisplayOrderNo)
                                      .ToList()
                            })
                            .OrderBy(o => o.GridOrderNo)
                            .ToList(),

                        DetailGridComponents = result.Item5.ToList()
                            .Where(c => c.ModuleCode == m.ModuleCode && c.GridPage.Equals("DETAIL", StringComparison.OrdinalIgnoreCase))
                            .GroupBy(c => c.GridOrderNo) // Grouping by GridOrderNo
                            .Select(group => new GridGroupComponent
                            {
                                GridOrderNo = group.Key,
                                Components = group.Select(MapToComponentGridDto)
                                      .OrderBy(o => o.DisplayOrderNo)
                                      .ToList()
                            })
                            .OrderBy(o => o.GridOrderNo)
                            .ToList()
                    })
                    .OrderBy(m => m.ModuleOrderNo)
                    .ToList()
                })
                .OrderBy(g => g.GroupOrderNo)
                .ToList();

            ApiResponse<ModuleComponentContainer> resultData = new ApiResponse<ModuleComponentContainer>
            {
                Data = new ModuleComponentContainer { Modules = components },
                ReturnCode = result.Item6.ReturnCode,
                ReturnMessage = result.Item6.ReturnMessage
            };

            return (ApiResponse<T>)(object)resultData;
        }


        #region Private Methods 
        //adjust the mapper later
        // Helper to avoid repeating mapping logic
        private Component MapToComponentDto(ComponentDto source)
        {
            return new Component
            {
                ModuleCode = source.ModuleCode,
                SubModuleCode = source.SubModuleCode, 
                DisplayOrderNo = source.DisplayOrderNo,
                InternalCode = source.InternalCode,
                //InfoId = source.InfoId.ToString(),
                //TemplateId = source.TemplateId.ToString(),
                InfoId = source.InfoId,
                TemplateId = source.TemplateId,
                Caption = source.Caption,
                Placeholder = source.Placeholder,
                DataType = source.DataType,
                DataFormat = source.DataFormat,
                ComponentType = source.ComponentType,
                //EventCode = source.EventCode,
                MethodCode = source.MethodCode,
                MinimumLength = source.MinimumLength,
                MaximumLength = source.MaximumLength,
                IsActive = source.IsActive,
                IsDeleted = source.IsDeleted,
                IsVisible = source.IsVisible,
                IsReadOnly = source.IsReadOnly,
                IsEnable = source.IsEnable,
                IsRequired = source.IsRequired

            };
        }

        private ComponentGrid MapToComponentGridDto(ComponentGridDto source)
        {
            return new ComponentGrid
            {
                ModuleCode = source.ModuleCode,
                SubModuleCode = source.SubModuleCode,
                DisplayOrderNo = source.DisplayOrderNo,
                InternalCode = source.InternalCode,
                //InfoId = source.InfoId.ToString(),
                //TemplateId = source.TemplateId.ToString(),
                InfoId = source.InfoId,
                TemplateId = source.TemplateId,
                Caption = source.Caption,
                Placeholder = source.Placeholder,
                DataType = source.DataType,
                DataFormat = source.DataFormat,
                ComponentType = source.ComponentType,
                //EventCode = source.EventCode,
                MethodCode = source.MethodCode,
                MinimumLength = source.MinimumLength,
                MaximumLength = source.MaximumLength,
                IsActive = source.IsActive,
                IsDeleted = source.IsDeleted,
                IsVisible = source.IsVisible,
                IsReadOnly = source.IsReadOnly,
                IsEnable = source.IsEnable,
                IsRequired = source.IsRequired,
                ColumnGroupNo = source.ColumnGroupNo,
                IsAllowSort = source.IsAllowSort,
                IsAscending = source.IsAscending
            };
        }
        #endregion
    }
}

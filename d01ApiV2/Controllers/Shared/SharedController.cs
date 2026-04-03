using d01ApiV2.Common.Constant;
using d01ApiV2.Model.Component;
using d01ApiV2.Model.Request;
using d01ApiV2.Repository.Interface.Profile;
using d01ApiV2.Repository.Interface.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace d01ApiV2.Controllers.Shared
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedController : ControllerBase
    {
        #region Private Fields
        private readonly ISharedRepository _sharedRepository;
        #endregion Private Fields

        #region Constructors
        public SharedController(ISharedRepository sharedRepository)
        {
            _sharedRepository = sharedRepository;
        }
        #endregion Constructors

        #region Public Methods
        /*
        [HttpGet("GetAdvanceSearchComponentTest")]
        public async Task<IActionResult> GetAdvanceSearchComponentTest()
        {
            RequestKeyValue request = new RequestKeyValue();

            request.Parameters.Add("ModuleCode", ModuleCode.BRAND);
            request.Parameters.Add("CompanyId", Guid.Empty.ToString());
            request.Parameters.Add("UserId", Guid.Empty.ToString());


            return Ok(await _sharedRepository.GetAdvanceSearchComponents<ResponseDataComponents>(request));
        }

        //[HttpGet]
        //[Route("[action]")]
        [HttpGet("AdvanceSearchComponents")]
        public async Task<IActionResult> AdvanceSearchComponents(RequestKeyValue request)
        {
            return Ok(await _sharedRepository.GetAdvanceSearchComponents<ResponseDataComponents>(request));
        }

        [HttpGet("PageComponents")]
        public async Task<IActionResult> PageComponents(RequestKeyValue request)
        {   
            return Ok(await _sharedRepository.GetPageComponents<ResponseDataComponents>(request));
        }
        //*/

        [HttpGet("GetComponentsTest")]
        public async Task<IActionResult> GetAdvanceSearchComponentTest()
        {
            RequestKeyValue request = new RequestKeyValue();

            request.Parameters.Add("CompanyId", "B71ECEEE-F966-4AF8-84BD-4C1074449171");
            request.Parameters.Add("UserId", Guid.Empty.ToString());
            request.Parameters.Add("ModuleCode", "ALL");
            //request.Parameters.Add("ModuleCode", ModuleCode.BRAND);
            request.Parameters.Add("SubModuleCode", "ALL");

            /*
             * Id	Code	Name	Description
            B71ECEEE-F966-4AF8-84BD-4C1074449171	davac01	davac01	davac01
            EC51B37C-8691-449D-B333-745785A88A9A	dvc	davac	davac test company
            //*/
            return Ok(await _sharedRepository.GetComponents<ModuleComponentContainer>(request));
        }

        [HttpGet("GetComponents")]
        public async Task<IActionResult> GetAdvanceSearchComponentTest(RequestKeyValue request)
        {
            return Ok(await _sharedRepository.GetComponents<ModuleComponentContainer>(request));
        }

        #endregion Public Methods
    }
}

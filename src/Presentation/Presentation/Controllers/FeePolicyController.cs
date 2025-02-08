using Application.RoomTypeFees.CreateFeePolicy;
using Domain.Shared;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Common.Validations;
using Presentation.Contracts.RoomTypeFees;

namespace Presentation.Controllers
{
    [Route("api/fee-policy")]
    [ApiController]
    public class FeePolicyController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICommonValidator _validator;

        public FeePolicyController(IMediator mediator, ICommonValidator validator)
        {
            _mediator = mediator;
            _validator = validator;
        }

        //[Permission(PermissionConstant.ViewRoomPrice)]
        //[HttpGet("get-list-of-fee-policy")]
        //public async Task<IActionResult> GetAllFeePolicy([FromQuery] FeePolicyForSearchDto request)
        //{
        //    try
        //    {
        //        var feePolicys = await _serviceManager.FeePolicyService.GetAllAsync(request);
        //        return Ok(BaseResponse<PaginatedList<FeePolicyDto>>.Success(feePolicys));
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(BaseResponse<PaginatedList<FeePolicyDto>>.Fail(ex.Message));
        //    }
        //}


        //[Permission(PermissionConstant.ViewRoomPrice)]
        //[HttpGet("get-list-of-fee-policy-by-room-type-id/{Id}")]
        //public async Task<IActionResult> GetAllFeePolicyByRoomTypeId(int Id, [FromQuery] FeePolicyForSearchDto request)
        //{
        //    try
        //    {
        //        var feePolicys = await _serviceManager.FeePolicyService.GetAllAsyncByRoomTypeId(Id, request);
        //        return Ok(BaseResponse<PaginatedList<FeePolicyWithExpressionDto>>.Success(feePolicys));
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(BaseResponse<PaginatedList<FeePolicyWithExpressionDto>>.Fail(ex.Message));
        //    }
        //}

        ////[Authorize(Policy = APIConstant.StaffPolicy)]
        //[HttpGet("get-single-fee-policy/{Id}")]
        //public async Task<IActionResult> GetFeePoilicy([FromRoute] FeePolicyForGetSingleDto request)
        //{
        //    try
        //    {
        //        var feePolicy = await _serviceManager.FeePolicyService.GetSingleAsync(request);
        //        return Ok(BaseResponse<FeePolicyDto>.Success(feePolicy));
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(BaseResponse<FeePolicyDto>.Fail(ex.Message));
        //    }
        //}

        /// <summary>
        /// Khi add thêm fee policy, cần phải add thêm các fee khác
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //[Authorize(Policy = APIConstant.StaffPolicy)]
        //[Permission(PermissionConstant.AddRoomPrice)]
        [HttpPost("add-new-fee-policy")]
        public async Task<IActionResult> AddFeePolicy([FromBody] CreateFeePolicyRequest request)
        {
            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult);
            }

            var createFeePolicyRequest = request.Adapt<CreateFeePolicyCommand>();
            var response = await _mediator.Send(createFeePolicyRequest);
            return Ok(response);
        }

        //[Authorize(Policy = APIConstant.StaffPolicy)]
        //[Permission(PermissionConstant.EditRoomPrice)]
        //[HttpPut("update-fee-policy/{id}")]
        //public async Task<IActionResult> UpdateFeePolicy([FromRoute] int id, [FromBody] FeePolicyForUpdateDto request)
        //{
        //    try
        //    {
        //        await _serviceManager.FeePolicyService.UpdateAsync(id, request);

        //        return Ok(BaseResponse<FeePolicyDto>.Success());
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(BaseResponse<FeePolicyDto>.Fail(ex.Message));
        //    }
        //}

        /// <summary>
        /// Cần xóa cả các Fee Liên quan (Id của các Fee giống với Fee cha!!!)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //[Authorize(Policy = APIConstant.StaffPolicy)]
        //[Permission(PermissionConstant.DeleteRoomPrice)]
        //[HttpDelete("delete-fee-policy/{id}")]
        //public async Task<IActionResult> DeleteFeePolicy([FromRoute] int id)
        //{
        //    try
        //    {
        //        await _serviceManager.FeePolicyService.DeleteAsync(id);
        //        return Ok(BaseResponse<FeePolicyDto>.Success());
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(BaseResponse<FeePolicyDto>.Fail(ex.Message));
        //    }
        //}

        //[HttpPut("update-fee-policy-full-attribute")]
        //public async Task<IActionResult> UpdateFeePolicy([FromBody] FeePolicyWithExpressionDto updatedPolicy)
        //{
        //    try
        //    {
        //        await _serviceManager.FeePolicyService.UpdateFeePolicyAsync(updatedPolicy);
        //        return Ok(BaseResponse<FeePolicyDto>.Success());
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(BaseResponse<FeePolicyDto>.Fail(ex.Message));
        //    }
        //}
    }
}
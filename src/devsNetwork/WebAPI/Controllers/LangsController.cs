using Application.Features.Languages.Commands.CreateLang;
using Application.Features.Languages.Commands.UpdateLang;
using Application.Features.Languages.DTOs;
using Application.Features.Languages.Models;
using Application.Features.Languages.Queries.GetListLang;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LangsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLangRequestDto createLangRequestDto)
        {
            CreateLangCommand createLangCommand = new() {CreateLangRequestDto = createLangRequestDto};
            CreatedLangResponseDto result = await Mediator.Send(createLangCommand);
            return Created("", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListLangQuery getListLangQuery = new() {PageRequest = pageRequest};
            GetListLangModel result = await Mediator.Send(getListLangQuery);
            return Created("", result);
        }
        // [HttpGet("{id}")]
        // public async Task<IActionResult> GetById([FromQuery] int id)
        // {
        //     GetListLangQuery getListLangQuery = new() {PageRequest = pageRequest};
        //     GetListLangModel result = await Mediator.Send(getListLangQuery);
        //     return Created("", result);
        // }
        [HttpPut]
        public async Task<IActionResult> GetList([FromBody] UpdateLangRequestDto updateLangRequestDto)
        {
            UpdateLangCommand updateLangCommand = new() {UpdateLangRequestDto = updateLangRequestDto};
            UpdatedLangResponseDto result = await Mediator.Send(updateLangCommand);
            return Created("", result);
        }
    }
}

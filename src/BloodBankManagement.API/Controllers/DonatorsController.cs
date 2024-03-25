using BloodBankManagement.Application.DTO.InputModels;
using BloodBankManagement.Core.Entities;
using BloodBankManagement.Core.Interfaces.Services;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace Blood_Bank_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DonatorsController : ControllerBase
    {
        private readonly IDonatorService _donatorService;
        public DonatorsController(IDonatorService donatorService)
        {
            _donatorService = donatorService;
        }

        [HttpGet]
        public IActionResult GetDonators()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetDonatorById(int id)
        {
            var donator = _donatorService.GetDonatorById(id);
            return Ok(donator);
        }

        [HttpPost]
        public IActionResult CreateDonator(CreateDonatorInputModel model)
        {
            int id = _donatorService.CreateDonator(model.Adapt<Donator>());
            return CreatedAtAction(nameof(GetDonatorById), new {id = id}, model);
        }
    }
}
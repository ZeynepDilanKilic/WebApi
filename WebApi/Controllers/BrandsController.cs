﻿using Business.Dtos.Responses;
using Business.Dtos.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Abstracts;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;


        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
            CreatedBrandResponse createBrandResponse = new CreatedBrandResponse();

            return Ok(_brandService.Add(createBrandRequest));

        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_brandService.GetAll());
        }
    }
}

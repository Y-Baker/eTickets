using eTickets.Data;
using eTickets.Data.Services;
using eTickets.DTOs.Producer;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers;

public class ProducersController : Controller
{
    private readonly IProducerService service;

    public ProducersController(IProducerService service)
    {
        this.service = service;
    }

    public async Task<IActionResult> Index()
    {
        var producers = await service.GetAll();
        return View(producers);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Details(int id)
    {
        var producer = await service.GetById(id);
        if (producer == null) return NotFound();
        return View(producer);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create(CreateProducerDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);

        var producer = new Producer
        {
            ProfilePictureURL = dto.ProfilePictureURL,
            FullName = dto.FullName,
            Bio = dto.Bio
        };

        await service.Add(producer);
        return RedirectToAction(nameof(Index));
    }
}

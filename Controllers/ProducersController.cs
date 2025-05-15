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

    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        var producer = await service.GetById(id);
        if (producer == null) return NotFound();
        return View(producer);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
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

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var producer = await service.GetById(id);
        if (producer == null) return NotFound();

        var dto = new UpdateProducerDto
        {
            ProfilePictureURL = producer.ProfilePictureURL ?? string.Empty,
            FullName = producer.FullName ?? string.Empty,
            Bio = producer.Bio ?? string.Empty
        };

        return View(dto);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, UpdateProducerDto dto)
    {
        if (!ModelState.IsValid)
        {
            return View(dto);
        }

        var producer = await service.GetById(id);
        if (producer == null) return NotFound();

        producer.ProfilePictureURL = dto.ProfilePictureURL;
        producer.FullName = dto.FullName;
        producer.Bio = dto.Bio;

        await service.Update(producer);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var producer = await service.GetById(id);
        if (producer == null) return NotFound();
        return View(producer);
    }

    [HttpPost]
    [ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var producer = await service.GetById(id);
        if (producer == null) return NotFound();

        await service.Delete(id);

        return RedirectToAction(nameof(Index));
    }
}

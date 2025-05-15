using eTickets.Data;
using eTickets.Data.Services;
using eTickets.DTOs.Cinema;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers;

public class CinemasController : Controller
{
    private readonly ICinemaService service;

    public CinemasController(ICinemaService service)
    {
        this.service = service;
    }

    public async Task<IActionResult> Index()
    {
        var cinemas = await service.GetAll();
        return View(cinemas);
    }
    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        var cinema = await service.GetById(id);
        if (cinema == null) return NotFound();
        return View(cinema);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCinemaDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);

        var cinema = new Cinema
        {
            Logo = dto.Logo,
            Name = dto.Name,
            Description = dto.Description
        };

        await service.Add(cinema);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var cinema = await service.GetById(id);
        if (cinema == null) return NotFound();

        var dto = new UpdateCinemaDto
        {
            Logo = cinema.Logo ?? string.Empty,
            Name = cinema.Name ?? string.Empty,
            Description = cinema.Description ?? string.Empty
        };

        return View(dto);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, UpdateCinemaDto dto)
    {
        if (!ModelState.IsValid)
        {
            return View(dto);
        }

        var cinema = await service.GetById(id);
        if (cinema == null) return NotFound();

        cinema.Logo = dto.Logo;
        cinema.Name = dto.Name;
        cinema.Description = dto.Description;

        await service.Update(cinema);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var cinema = await service.GetById(id);
        if (cinema == null) return NotFound();
        return View(cinema);
    }

    [HttpPost]
    [ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var cinema = await service.GetById(id);
        if (cinema == null) return NotFound();

        await service.Delete(id);

        return RedirectToAction(nameof(Index));
    }
}


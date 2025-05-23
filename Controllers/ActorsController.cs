using eTickets.Data;
using eTickets.Data.Services;
using eTickets.DTOs.Actor;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers;

public class ActorsController : Controller
{
    private readonly IActorService service;

    public ActorsController(IActorService service)
    {
        this.service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var actors = await service.GetAll();
        return View(actors);
    }

    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        var actor = await service.GetById(id);
        if (actor == null) return NotFound();
        return View(actor);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateActorDto dto)
    {
        if (!ModelState.IsValid)
            return View(dto);

        var actor = new Actor
        {
            ProfilePictureURL = dto.ProfilePictureURL,
            FullName = dto.FullName,
            Bio = dto.Bio
        };

        await service.Add(actor);
        // await service.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }


    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var actor = await service.GetById(id);
        if (actor == null) return NotFound();

        var dto = new UpdateActorDto
        {
            ProfilePictureURL = actor.ProfilePictureURL ?? string.Empty,
            FullName = actor.FullName ?? string.Empty,
            Bio = actor.Bio ?? string.Empty
        };

        return View(dto);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, UpdateActorDto dto)
    {
        if (!ModelState.IsValid)
        {
            return View(dto);
        }

        var actor = await service.GetById(id);
        if (actor == null) return NotFound();

        actor.ProfilePictureURL = dto.ProfilePictureURL;
        actor.FullName = dto.FullName;
        actor.Bio = dto.Bio;

        await service.Update(actor);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var actor = await service.GetById(id);
        if (actor == null) return NotFound();
        return View(actor);
    }

    [HttpPost]
    [ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var actor = await service.GetById(id);
        if (actor == null) return NotFound();

        await service.Delete(id);

        return RedirectToAction(nameof(Index));
    }
}

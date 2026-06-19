using Microsoft.AspNetCore.Mvc;
using ShelterApi.Data;
using ShelterApi.DTOs;
using ShelterApi.Interfaces;
using ShelterApi.Models;

namespace ShelterApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DogsController : ControllerBase
{
    private readonly IRepository<Dog> _repo;

    public DogsController(IRepository<Dog> repo) { _repo = repo; }

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _repo.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id) {
        var dog = await _repo.GetByIdAsync(id);
        return dog is null ? NotFound() : Ok(dog);
    }

    [HttpGet("{id}/sound")]
    public async Task<IActionResult> Sound(int id) {
        var dog = await _repo.GetByIdAsync(id);
        if (dog is null) return NotFound();
        return Ok(new { sound = dog.MakeSound(), info = dog.GetInfo() });
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateDogDto dto) {
        var dog = new Dog(dto.Name, dto.Age, dto.Breed);
        await _repo.AddAsync(dog);
        ShelterStats.Instance.RecordArrival();
        return CreatedAtAction(nameof(Get), new { id = dog.Id }, dog);
    }

    [HttpPost("{id}/adopt")]
    public async Task<IActionResult> Adopt(int id) {
        var dog = await _repo.GetByIdAsync(id);
        if (dog is null) return NotFound();
        dog.Adopt();
        await _repo.UpdateAsync(dog);
        ShelterStats.Instance.RecordAdoption();
        return Ok(new { message = $"{dog.Name} sahiplendirildi!" });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id) {
        if (!await ExistsAsync(id)) return NotFound();
        await _repo.DeleteAsync(id);
        return NoContent();
    }

    private async Task<bool> ExistsAsync(int id) =>
        await _repo.GetByIdAsync(id) != null;
}
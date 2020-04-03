using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;


namespace AnimalShelter.Controllers
{
  [ApiVersion("1.0")] 
  [Route("api/v{apiVersion}/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string type, string gender, string name, int age)
    {
      var query = _db.Animals.AsQueryable();

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }
      if (name != null)
      {
      query = query.Where(entry => entry.Name == name);
      }

      return query.ToList();
    }

    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    // GET api/animals/5
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
        return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }

     // PUT api/animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
        animal.AnimalId = id;
        _db.Entry(animal).State = EntityState.Modified;
        _db.SaveChanges();
    }
    // DELETE api/animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
    // GET api/animals/random
    [HttpGet("random")]
    public ActionResult<Animal> Random ()
    {
      List<Animal> animals = _db.Animals.ToList();
      var rand = new Random();
      int random = rand.Next(0, animals.Count-1);
      return animals[random];
    }

  }
}
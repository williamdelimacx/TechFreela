using Microsoft.AspNetCore.Mvc;
using TechFreela.API.Models;

namespace TechFreela.API.Controllers;

[Route("api/projects")]
public class ProjectsController : ControllerBase
{
    // api/projects?query=abc
    [HttpGet]
    public IActionResult Get(string query)
    {
        // Search all or filter
        return Ok();
    }

    // api/projects/1
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        // Search for the project
        // return NotFound();

        return Ok();
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateProjectModel createProject)
    {
        if (createProject.Title.Length > 50)
        {
            return BadRequest();
        }

        // Register the project

        return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
    }

    // api/projects/2
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
    {
        if (updateProject.Description.Length > 200)
        {
            return BadRequest();
        }

        // I update the object

        return NoContent();
    }

    // api/projects/3
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Search, if not exists, returns NotFound()

        // Remove

        return NoContent();
    }
}

using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items/{id}")]
    public ActionResult Details(int id)
    {
      Item newItem = new Item(Request.Form["new-item"]);
      List<Item> allItems = Item.GetAll();
      return View("Index", allItems);
    }

  }
}

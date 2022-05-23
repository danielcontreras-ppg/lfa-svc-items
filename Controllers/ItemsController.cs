using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json;
using ItemApi.Models;
using Microsoft.AspNetCore.Cors;
namespace ItemApi.Controllers;

[ApiController]
[Route("api/[controller]/{action}")]

//[DisableCors]
public class ItemsController : ControllerBase
{
    [EnableCors("TestPolicy")]

    [HttpGet]
    public IEnumerable<Item> GetItems()
    {
        List<Item> items = ListOfItems();
        return items;
    }


    private List<Item> ListOfItems()
    {
        var json = new WebClient().DownloadString("https://my-json-server.typicode.com/danielcontreras-ppg/myjsonserver-lfaitems/items");
        var items = JsonConvert.DeserializeObject<List<Item>>(json);
        return items;
    }
}
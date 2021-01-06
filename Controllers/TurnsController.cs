using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using DogBarderShopWebApp.Servies;
using System.Linq;
using System.Threading.Tasks;
using DogBarderShopWebApp.Models;

namespace DogBarderShopWebApp.Controllers
{
    public class TurnsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public List<WatingToTurns> GetAllWatingToTurns()
        {
            return new TurnsServies().GetAllWatingToTurns();
        }
        public TurnDetails GetTurnDetails(decimal turnId)
        {
            return new TurnsServies().GetTurnDetails(turnId);
        }
        public object DeleteTurn(decimal turnId)
        {
            return new TurnsServies().DeleteTurn(turnId);
        }
        public object UpdateTurn(decimal turnId, DateTime turnDate)
        {
            return new TurnsServies().UpdateTurn(turnId, turnDate);
        }
        public object CreateTurn(DateTime turnDate, decimal userId)
        {
            return new TurnsServies().CreateTurn(turnDate, userId);
        }
        public List<DateTime> GetAllFreeTurns(DateTime date)
        {
            return new TurnsServies().GetAllFreeTurns(date);
        }
    }
}

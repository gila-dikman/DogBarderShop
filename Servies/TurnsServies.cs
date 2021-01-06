using DogBarderShopWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBarderShopWebApp.Servies
{
    public class TurnsServies
    {
        public List<WatingToTurns> GetAllWatingToTurns()
        {
            return new DogBarbershopDBContext().Query<WatingToTurns>().FromSql("spGetAllWatingToTurns").ToList();
        }
        public TurnDetails GetTurnDetails(decimal turnId)
        {
            return new DogBarbershopDBContext().Query<TurnDetails>().FromSql("spGetTurnDetails @p0", turnId).ToList()[0];
        }
        public object DeleteTurn(decimal turnId)
        {
            return new DogBarbershopDBContext().Query<Number>().FromSql("spDeleteTurn @p0", turnId);
        }
        public object UpdateTurn(decimal turnId, DateTime turnDate)
        {
            return new DogBarbershopDBContext().Query<Number>().FromSql("spUpdateTurn @p0 , @p1", turnId, turnDate);
        }
        public object CreateTurn(DateTime turnDate, decimal userId)
        {
            var s = new DogBarbershopDBContext().Query<Number>().FromSql("spCreateTurn @p0 , @p1", turnDate, userId);
            return s;
        }
        public List<DateTime> GetAllFreeTurns(DateTime date)
        {
            var startDate = date.AddHours(8).AddMinutes(30);
            var endDate = date.AddHours(22);
            List<DateTime> times = new List<DateTime>();
            
            while (startDate <= endDate)
            {
                times.Add(startDate);
                startDate = startDate.AddMinutes(15);
            }
            return times;
        }
    }
}

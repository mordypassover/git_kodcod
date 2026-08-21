using DronesConsumer.Data;
using DronesConsumer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DronesConsumer.Services
{
    public class KafkaToDbInserter
    {
        private readonly MyDbContext _dbContaxt;

        public KafkaToDbInserter(MyDbContext dbContaxt)
        {
            _dbContaxt = dbContaxt;
        }

        public async Task<bool> ProcessModel(string modelString)
        {
            var model = JsonSerializer.Deserialize<UavModel>(modelString);
            if (model == null)
            {
                return false;
            }
            _dbContaxt.Models.Add(model);
            await _dbContaxt.SaveChangesAsync();
            return true;
        }
        public async Task<bool> ProcessUnit(string UnitString)
        {
            var unit = JsonSerializer.Deserialize<Unit>(UnitString);
            if (unit == null)
            {
                return false;
            }
            _dbContaxt.Units.Add(unit);
            await _dbContaxt.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ProcessTrack(string trackString)
        {
            var track = JsonSerializer.Deserialize<Track>(trackString);
            if (track == null)
            {
                return false;
            }
            _dbContaxt.Tracks.Add(track);
            await _dbContaxt.SaveChangesAsync();
            return true;
        }
    }
}

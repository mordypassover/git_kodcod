using EtlConsumer.Data;
using EtlConsumer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EtlConsumer.Services;

public class KafkaToDbService
{
    private readonly MyDbContaxt _dbContext;

    public KafkaToDbService(MyDbContaxt dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<bool> AddAnalystToDb(string incommingMessage)
    {
        var analyst = JsonSerializer.Deserialize<Analyst>(incommingMessage);
        if (analyst == null)
        {
            return false;
        }
        _dbContext.Analysts.Add(analyst);
        await _dbContext.SaveChangesAsync();
        return true;
    }
    public async Task<bool> AddCallToDb(string incommingMessage)
    {
        var call = JsonSerializer.Deserialize<Call>(incommingMessage);
        if (call == null) 
        {
            return false;
        }
        _dbContext.Calls.Add(call);
        await _dbContext.SaveChangesAsync();
        return true;
    }
}

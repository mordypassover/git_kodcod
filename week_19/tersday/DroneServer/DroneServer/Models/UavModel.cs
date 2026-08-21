using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronesConsumer.Models;

public class UavModel
{
    [Key]
    public int model_id {  get; set; }
    public string model_name {  get; set; }
    public string model_class {  get; set; }
    public int max_range_km {  get; set; }
    public int endurance_minutes {  get; set; }
    public string sensor_payload {  get; set; }
    public ICollection<Unit> Units { get; set; }= new List<Unit>();
}

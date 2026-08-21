using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronesConsumer.Models;

public class Track
{
    [Key]
    public int track_id {  get; set; }
    public int unit_id {  get; set; }
    public DateTime report_time {  get; set; }
    public double latitude {  get; set; }
    public double longitude {  get; set; }
    public int altitude_m {  get; set; }
    public int signal_strength {  get; set; }

    public Unit? Unit { get; set; }
}

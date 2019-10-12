using System;
using System.Collections.Generic;
using System.Text;

namespace CooperativaXZ.Infra.CrossCutting.SharedUI.ViewModel
{
    public class WeatherForecastViewModel
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}

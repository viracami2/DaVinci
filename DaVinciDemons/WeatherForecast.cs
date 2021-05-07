using System;

namespace DaVinciDemons
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public int TemperatureVirra => 31 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}

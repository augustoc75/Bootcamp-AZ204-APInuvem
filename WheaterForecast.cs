namespace APITempDIO
{
    public class WheaterForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 +  (int)(TemperatureC / 0.556);
        public string Summary { get; set; }
    }
}

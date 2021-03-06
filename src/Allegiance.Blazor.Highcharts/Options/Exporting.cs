﻿using Newtonsoft.Json;


namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Exporting
    {
        [JsonProperty("buttons", NullValueHandling = NullValueHandling.Ignore)]
        public Buttons Buttons { get; set; }

        [JsonProperty("sourceWidth", NullValueHandling = NullValueHandling.Ignore)]
        public long? SourceWidth { get; set; }

        [JsonProperty("sourceHeight", NullValueHandling = NullValueHandling.Ignore)]
        public long? SourceHeight { get; set; }

        [JsonProperty("chartOptions", NullValueHandling = NullValueHandling.Ignore)]
        public ChartOptions ChartOptions { get; set; }

        public Exporting(Buttons buttons = null, long? sourceWidth = null, long? sourceHeight = null, ChartOptions chartOptions = null)
        {
            Buttons = buttons;
            SourceWidth = sourceWidth;
            SourceHeight = sourceHeight;
            ChartOptions = chartOptions;
        }

        public Exporting()
        {

        }
    }
}

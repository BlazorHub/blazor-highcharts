﻿using Newtonsoft.Json;


namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotLines
    {
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }
        [JsonProperty("dashStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string DashStyle { get; set; }
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }
        [JsonProperty("zIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? ZIndex { get; set; }
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public Label Label { get; set; }
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

    }
}
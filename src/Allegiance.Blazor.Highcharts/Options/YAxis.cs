﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class YAxis
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public Title Title { get; set; }

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public long? Min { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Labels Labels { get; set; }
        [JsonProperty("className", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassName { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public long? Max { get; set; }

        [JsonProperty("lineWidth", NullValueHandling = NullValueHandling.Ignore)]
        public long? LineWidth { get; set; }

        [JsonProperty("tickPositions", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> TickPositions { get; set; }

        [JsonProperty("gridLineColor", NullValueHandling = NullValueHandling.Ignore)]
        public string GridLineColor { get; set; }

        [JsonProperty("stops", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Stops { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }

        [JsonProperty("lineColor", NullValueHandling = NullValueHandling.Ignore)]
        public string LineColor { get; set; }

        [JsonProperty("gridLineWidth", NullValueHandling = NullValueHandling.Ignore)]
        public long? GridLineWidth { get; set; }

        public YAxis()
        {
            Title = new Title();
            Labels = new Labels();
            ClassName = null;
        }

        public YAxis(Title title = null, Labels labels = null, string classname = null)
        {
            Title = title;
            Labels = labels;
            ClassName = classname;
        }
    }
}
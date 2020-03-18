﻿using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Legend
    {
        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public string Layout { get; set; }

        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public string Align { get; set; }

        [JsonProperty("verticalAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string VerticalAlign { get; set; }

        public Legend()
        {

        }

        public Legend(string layout, string align, string verticalAlign)
        {
            Layout = layout;
            Align = align;
            VerticalAlign = verticalAlign;
        }
    }
}

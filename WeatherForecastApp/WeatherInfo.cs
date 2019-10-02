﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecastApp
{
    public class WeatherInfo
    {
        public class root
        {
            public string name { get; set; }
            public Sys sys { get; set; }
            public Wind wind { get; set; }
            public Main main { get; set; }
            public Clouds clouds { get; set; }
            public List<Weather> weatherList { get; set; }


            public void RootToScreen(root _root)
            {
                Console.WriteLine($"City: {_root.name}");
                Console.WriteLine($"Country: {_root.sys.country}");
                Console.WriteLine($"Wind speed: {_root.wind.speed} m/s");
                Console.WriteLine($"Temperature: {_root.main.temp - 273} C");
                Console.WriteLine($"Pressure: {_root.main.pressure} hpa");
                Console.WriteLine($"Clouds: {_root.clouds.all.ToString()} %");
                //Console.WriteLine($"Weather: ");
                //var array = weatherList.ToArray();
                //for (int i = 0; i < array.Length - 1; i++)
                //    Console.WriteLine(array[i]);
            }
        }
    }
}

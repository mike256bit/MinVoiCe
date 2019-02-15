using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class WeekNumber
    {
        public static Dictionary<int, string> WeekDict = new Dictionary<int, string>();
        public static int CurrentWeek = 0;

        //Generate weeks -- this should be it's own DB maybe? Naw.
        public static void WeekGenerator()
        {

            DateTime StartDate = new DateTime(2018, 12, 30);
            DateTime EndDate = StartDate.AddDays(6);

            DateTime CurrentDate = DateTime.Today;
            

            for(int i = 1;  i < 53; i++)
            {
                if (StartDate <= CurrentDate && CurrentDate <= EndDate)
                {
                    CurrentWeek = i;
                }

                string DateRange = string.Format("{0} - {1}", StartDate.ToString("d"), EndDate.ToString("d"));

                WeekDict.Add(i, DateRange);

                StartDate = StartDate.AddDays(7);
                EndDate = EndDate.AddDays(7);
            }
        }

        public static List<SelectListItem> SelectWeeks()
        {
            List<SelectListItem> SelectWeeks = new List<SelectListItem>();

            foreach (KeyValuePair<int, string> kv in WeekDict)
            {

                SelectWeeks.Add(new SelectListItem
                {
                    Value = kv.Key.ToString(), 
                    Text = kv.Value
                    
                });
            }

            return SelectWeeks;
        }

    }
}

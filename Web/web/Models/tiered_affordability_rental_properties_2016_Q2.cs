using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    enum Level
    {
        Bottom_Tier,
        Middle_Tier,
        Upper_Tier
    }

    public class tiered_affordability_rental_properties_2016_Q2
    {
        const string regionID = "394458";
        const string regionName = "Charlotte, NC";
        const string SizeRank = "24";
        Level tier; // But really, "Bottom Tier", "Middle Tier", or "Upper Tier"
        string date; // In format yyyy-mm-dd
        double income;
        int zri;
        double PercentIncomeSpentOnRent;
    }
}
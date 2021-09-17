using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Model
{
    public enum Priority
    {  Normal,Low,High }
    public enum IncidentType 
    {Hardware,Software,Service }

    //public enum Deadlines {[Description ("7 days")] sevenDays, [Description("6 days")] sixDays, [Display(Name = "5 days")] fiveDays,
    //    [Display(Name = "4 days")] fourDays, [Display(Name = "3 days")] ThreeDays, [Display(Name = "2 days")] Twodays, [Display(Name = "1 day")] oneDay }
    public enum Status
    { Open, Close}
}

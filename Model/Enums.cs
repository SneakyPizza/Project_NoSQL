using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Model
{
    public enum Priority
    { Normal,High,Low }
    public enum IncidentType 
    {Hardware,Software,Service }
    public enum Status
    { Open, Close, Pending}
}

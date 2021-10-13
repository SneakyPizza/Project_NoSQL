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
    { Registered,Processing,OnHold,Solved,Rejected}
    public enum UserRole
    {Admin,User}
}

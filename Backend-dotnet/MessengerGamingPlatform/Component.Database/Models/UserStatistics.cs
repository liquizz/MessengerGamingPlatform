using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Component.Database.Models
{
    public class UserStatistics
    {
        [Key]
        public int UserStatisticsId { get; set; }
        public User User { get; set; }
    }
}

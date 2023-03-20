using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator.Models
{
    [Table("_BMIList")]
    public class BMIData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100), Unique]
        public string Name { get; set; }

        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMIScore { get; set; }
        public String BMIResult { get; set; }
        public String TimeStamp { get; set; }
    }
}

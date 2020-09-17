using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InClassPractice_17Sep.Models
{
    // Declares the name of the database table.
    [Table("Manufacture")]
    public partial class CodeSecondCar
    { 

         // All annotations will bind to the next property in the file.

        // Declare a primary key.
        [Key]
        // Specifies AUTO_INCREMENT.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // Declare the column name and the data type.
        // MySQL data type, NOT C# data type.
        [Column("id", TypeName = "int(10)")]
        // Declare the C# property that will map onto that database column.
        public int ID { get; set; }

        [Column("Name", TypeName = "varchar(30)")]
        // Specifies NOT NULL on nullable types.
        // Ints do not require this to be NOT NULL as they are not nullable.
        // You must make a nullable int (int?) in order to specify NULL.
        [Required]
        public string Name { get; set; }

        [Column("YearFounded", TypeName = "int(10)")]
        // To make a NULL int, we can specify the data type as "int?".
        public int? YearFounded { get; set; }

    }
}

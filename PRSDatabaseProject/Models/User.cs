using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSDatabaseProject.Models {
    public class User {

        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public String Username { get; set; }

        [MaxLength(30)]
        [Required]
        public string Password { get; set; }

        [MaxLength(30)]
        [Required]
        public string Firstname { get; set; }

        [MaxLength(30)]
        [Required]
        public string Lastname { get; set; }

        [MaxLength(12)]
        public string Phone { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        public bool IsReviewer { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        public virtual ICollection<Request> Request { get; set; }//Hint to the relationship between Request and User

    }
}

//| Name       | Type    | Null | Len | Unique | PK  | FK  | Def | Gen | Notes |
//| ----       | ----    | ---- | --- | ------ | --- | --- | --- | --- | ----- |
//| Id         | Integer | No   | N/A | Yes    | Yes | No  | No  | Yes | 1,1   | ///This is an Identity column in C#
//| Username   | String  | No   | 30  | Yes    | No  | No  | No  | No  |       |
//| Password   | String  | No   | 30  | No     | No  | No  | No  | No  |       |
//| Firstname  | String  | No   | 30  | No     | No  | No  | No  | No  |       |
//| Lastname   | String  | No   | 30  | No     | No  | No  | No  | No  |       |Id//Ignore this
//| Phone      | String  | Yes  | 12  | No     | No  | No  | No  | No  |       |
//| Email      | String  | Yes  | 255 | No     | No  | No  | No  | No  |       |
//| IsReviewer | Boolean | No   | N/A | No     | No  | No  | 1   | No  |       |///SQL does not have BOOLEAN, use T or F; Y, N; 1,2; but often a 'bit' data type is used
//| IsAdmin    | Boolean | No   | N/A | No     | No  | No  | 1   | No  |       |


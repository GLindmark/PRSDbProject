using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRSDatabaseProject.Models {
    public class Vendor {

        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Code { get; set; }

        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        [MaxLength(30)]
        [Required]
        public string Address { get; set; }

        [MaxLength(30)]
        [Required]
        public string City { get; set; }

        [MaxLength(2)]
        [Required]
        public string State { get; set; }

        [MaxLength(5)]
        [Required]
        public string Zip { get; set; }

        [MaxLength(12)]
        public string Phone { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        public Vendor (){
        }
    }
}


//| Name       | Type    | Null | Len | Unique | PK  | FK  | Def | Gen | Notes |
//| ----       | ----    | ---- | --- | ------ | --- | --- | --- | --- | ----- |
//| Id         | Integer | No   | N/A | Yes    | Yes | No  | No  | Yes | 1,1   |
//| Code       | String  | No   | 30  | Yes    | No  | No  | No  | No  |       |//Ask if we make the code? Does the end user enter?  Algoritm? i.e.
//| Name       | String  | No   | 30  | No     | No  | No  | No  | No  |       |
//| Address    | String  | No   | 30  | No     | No  | No  | No  | No  |       |//Should there be a second line?
//| City       | String  | No   | 30  | No     | No  | No  | No  | No  |       |
//| State      | String  | No   | 2   | No     | No  | No  | No  | No  |       |
//| Zip        | String  | No   | 5   | No     | No  | No  | No  | No  |       |
//| Phone      | String  | Yes  | 12  | No     | No  | No  | No  | No  |       |
//| Email      | String  | Yes  | 255 | No     | No  | No  | No  | No  |       |



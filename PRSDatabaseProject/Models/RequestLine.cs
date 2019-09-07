using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRSDatabaseProject.Models {
    public class RequestLine {

        [Key]
        public int Id { get; set; }

        [Required]
        public int RequestId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }


        [ForeignKey("RequestId")]
        public Request Request { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}

//​
//| Name            | Type    | Null | Len  | Unique | PK  | FK  | Def | Gen | Notes |
//| ----            | ----    | ---- | ---  | ------ | --- | --- | --- | --- | ----- |
//| Id              | Integer | No   | N/A  | Yes    | Yes | No  | No  | Yes | 1,1   |
//| RequestId       | Integer | No   | N/A  | No     | No  | Yes | No  | No  |       |
//| ProductId       | Integer | No   | N/A  | No     | No  | Yes | No  | No  |       |
//| Quantity        | Integer | No   | N/A  | No     | No  | No  | Yes | No  | def to 1 |
//​
//Notes:
//​
//* `Quantity` must be greater than or equal to zero(cannot be negative)

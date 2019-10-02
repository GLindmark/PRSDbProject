using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRSDatabaseProject.Models {
    public class Request {


        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public String Description { get; set; }

        [Required]
        [MaxLength(80)]
        public string Justification { get; set; }

        [MaxLength(80)]
        public string RejectionReason { get; set; }

        //[Required]
        [MaxLength(20)]
        [DefaultValue("Pickup")]
        public string DeliveryMode { get; set; }

        //[Required]
        [MaxLength(10)]
        [DefaultValue("New")]
        public string Status { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual List<RequestLine> RequestLines { get; set; }
    }
}


//| Name            | Type    | Null | Len  | Unique | PK  | FK  | Def | Gen | Notes |
//| ----            | ----    | ---- | ---  | ------ | --- | --- | --- | --- | ----- |
//| Id              | Integer | No   | N/A  | Yes    | Yes | No  | No  | Yes | 1,1   |
//| Description     | String  | No   | 80   | No     | No  | No  | No  | No  |       |
//| Justification   | String  | No   | 80   | No     | No  | No  | No  | No  |       |
//| RejectionReason | String  | Yes  | 80   | No     | No  | No  | No  | No  |       |// Null on Create or edit, only gets filled upon reivew.
//| DeliveryMode    | String  | No   | 20   | No     | No  | No  | Yes | No  | Def 'Pickup' |
//| Status          | String  | No   | 10   | No     | No  | No  | Yes | No  | Def 'NEW'    |//Users are not allowed to change this.  Status is always NEW when Created.
//| Total           | Decimal | No   | 11,2 | No     | No  | No  | Yes | No  | Def 0 |//Grand total for the request which includes all of the lines.  Each time there is a change, the total needs to change accordingly..  Need a Method to pass in a request ID, figure out the total and then return, every time there is a change to the order.

//| UserId          | Integer | No   | N/A  | No     | No  | Yes | No  | No  | FK to User |//cannot be edited.  It is based on the log in User.  Must force a log in to create the order so they have the user id.




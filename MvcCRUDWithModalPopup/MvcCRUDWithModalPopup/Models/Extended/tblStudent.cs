using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCRUDWithModalPopup.Models
{
    [MetadataType(typeof(tblStudentsMetaData))]
    public partial class tblStudent
    {

    }

    public class tblStudentsMetaData
    {
        [Required (AllowEmptyStrings =false, ErrorMessage ="Please Provide Name")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Father's Name")]
        public string FatherName { get; set; }
    }
}
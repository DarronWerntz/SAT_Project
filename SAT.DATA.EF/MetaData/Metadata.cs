using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SAT.DATA.EF.Models/*.MetaData*/
{

    #region Course

    public class CourseMetadata
    {        
        public int CourseId { get; set; }


        [Required (ErrorMessage="Required")]
        [StringLength(50, ErrorMessage ="Max 50 characters")]
        [Display(Name="Course Name")]
        public string CourseName { get; set; } = null!;


        [Required(ErrorMessage = "Required")]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; } = null!;


        [Required(ErrorMessage = "Required")]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        [StringLength(250, ErrorMessage ="Max 250 characters")]
        public string? Curriculum { get; set; }

        [StringLength(500, ErrorMessage = "Max 500 characters")]
        public string? Notes { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

    }
    #endregion



    #region Enrollment
    public class EnrollmentMetadata
    {

        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage ="Required")]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

    }
    #endregion



    #region ScheduledClass
    public class ScheduledClassMetadata
    {
        public int ScheduledClassId { get; set; }


        public int CourseId { get; set; }


        [Required(ErrorMessage = "Required")]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }


        [Required(ErrorMessage = "Required")]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Instructor Name")]
        [StringLength(40, ErrorMessage ="Max 40 characters")]
        public string InstructorName { get; set; } = null!;


        [Required(ErrorMessage = "Required")]
        [StringLength(20, ErrorMessage = "Max 20 characters")]
        public string Location { get; set; } = null!;


        public int Scsid { get; set; }
    }
    #endregion



    #region ShecduledClassStatus
    public class ScheduledClassStatusMetadata
    {
        public int Scsid { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "SCS Name")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string Scsname { get; set; } = null!;
    }
    #endregion



    #region Student
    public class StudentMetadata
    {


        public int StudentId { get; set; }


        [Required(ErrorMessage = "Required")]
        [Display(Name = "First Name")]
        [StringLength(20, ErrorMessage = "Max 20 characters")]
        public string FirstName { get; set; } = null!;


        [Required(ErrorMessage = "Required")]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "Max 20 characters")]
        public string LastName { get; set; } = null!;


        [StringLength(15, ErrorMessage = "Max 15 characters")]
        public string? Major { get; set; }


        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string? Address { get; set; }


        [StringLength(25, ErrorMessage = "Max 25 characters")]
        public string? City { get; set; }


        [StringLength(2, ErrorMessage = "Max 2 characters")]
        public string? State { get; set; }


        [StringLength(10, ErrorMessage = "Max 10 characters")]
        public string? ZipCode { get; set; }


        [StringLength(13, ErrorMessage = "Max 13 characters")]
        public string? Phone { get; set; }


        [Required(ErrorMessage = "Required")]
        [StringLength(60, ErrorMessage = "Max 60 characters")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;


        [Display(Name="Photo")]
        [StringLength(100, ErrorMessage = "Max 100 characters")]
        public string? PhotoUrl { get; set; }


        public int Ssid { get; set; }


    }
    #endregion



    #region StudentStatus
    public class StudentStatusMetadata
    {


        public int Ssid { get; set; }



        [Required(ErrorMessage = "Required")]
        [Display(Name = "Student Status")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string Ssname { get; set; } = null!;




        [Display(Name = "Status Description")]
        [StringLength(250, ErrorMessage = "Max 250 characters")]
        public string? Ssdescription { get; set; }


    }

    #endregion

}

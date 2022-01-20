using System;

namespace Safe_T_Software.Models
{
    public class DutyTitle
    {
    //  Fields

        private static Guid TitleID { get; set; }
        private static string Title { get; set; }
        private static string Description { get; set; }

    // Constructors
        
        /// <summary>
        ///     Basic constructor that only takes in a string for the title
        /// </summary>
        /// <param name="title">string value that contains the value of the duty title being inputted/assigned</param>
        public DutyTitle(string title)
        {
            TitleID = Guid.NewGuid();
            Title = title;
        }

        /// <summary>
        ///     More in-depth constructor that allows for the description to be set
        /// </summary>
        /// <param name="title"></param>
        /// <param name="descript"></param>
        public DutyTitle(string title, string descript)
        {
            TitleID = Guid.NewGuid();
            Title = title;
            Description = descript;
        }

    // Methods

        public static string SetTitle(string newTitle)
        {
            Title = newTitle;
            return Title;
        }

        public static string SetDecript(string descript)
        {
            Description = descript;
            return Description;
        }


    }
}
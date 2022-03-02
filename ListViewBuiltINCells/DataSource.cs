using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewBuiltINCells
{
    public static class DataSource
    {
        public static List<Student> Students = new List<Student>
        {
            new Student()
            {
                Name = "Andre",
                Comment = "Good student",
                IsInternational = true,
                Photo = "https://www.taylorherring.com/wp-content/uploads/2015/03/Archetypal-Male-Face-of-Beauty-embargoed-to-00.01hrs-30.03.15.jpg"
            },
            new Student()
            {
                Name = "Mark",
                Comment = "Professional developer",
                IsInternational = false,
                Photo = "https://www.faceapp.com/static/img/content/compare/beard-example-before@3x.jpg"

            },
            new Student()
            {
                Name = "Sam",
                Comment = "Having some issue with logic",
                IsInternational = false,
                Photo = "https://image.shutterstock.com/image-photo/close-portrait-young-smiling-handsome-260nw-1180874596.jpg"
            }

        };
    }
}

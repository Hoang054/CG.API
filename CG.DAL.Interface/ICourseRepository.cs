using CG.Domain.Response.Course;
using System;
using System.Collections.Generic;
using System.Text;

namespace CG.DAL.Interface
{
    public interface ICourseRepository
    {
        IEnumerable<CourseView> Gets();
    }
}

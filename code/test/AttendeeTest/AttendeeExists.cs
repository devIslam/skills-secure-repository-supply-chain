using System;
using Xunit;
using Xunit.Extensions;
using Attendees;

namespace AttendeeTest
{
    public class AttendeeTest
    {
        [Fact]
        public void AttendeeExistsReturnTrue()
        {
            //898989
//595959
            //tttt
            //5555
            Attendee attendee = new Attendee();
            bool doesExist = attendee.AddAttendee("doesnotexist");
            Assert.False(doesExist, "The attendee does not exist");
        }
    }
}




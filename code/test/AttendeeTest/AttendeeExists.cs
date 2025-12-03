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
//595959
            //tttt
            Attendee attendee = new Attendee();
            bool doesExist = attendee.AddAttendee("doesnotexist");
            Assert.False(doesExist, "The attendee does not exist");
        }
    }
}



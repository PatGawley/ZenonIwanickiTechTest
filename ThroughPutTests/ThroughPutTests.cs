using System;
using System.Collections.Generic;
using RateMonitoring;
using Xunit;

namespace ThroughPutTests
{
    public class ThroughPutTests
    {
        [Fact]
        public void GivenConfiguredBoundaries_WhenThroughPutIsBelowConfiguredBoundaryAndNotInAndNotCurrent_ThenALowerBoundaryNotMetEventIsFired()
        {
            string eventFired = null;

            var givenConfiguredBoundaries = BuildConfiguredBoundaries();

            var throughPut = new ThroughPut(givenConfiguredBoundaries, 
                new DateTimeWhichReturns1210on18Jan2018());

            throughPut.OnLowerBoundaryNotMet += delegate (object sender, EventArgs e)
            {
                eventFired = e.ToString();
            };

            throughPut.RecordThroughPut(1, DateTime.Parse("2018-01-18 12:05:16"));
            Assert.NotNull(eventFired);
        }

        public class DateTimeWhichReturns1210on18Jan2018 : IDateTime
        {
            public DateTime Now()
            {
                return DateTime.Parse("2018-01-18 12:10:00");
            }
        }





        List<IInterval> BuildConfiguredBoundaries()
        {
            //TODO: Build List<IInterval> based on following values
            //Table A
            //--------
            //From(>)     To(<=)      Lower Upper
            //12:00am     12:30am     5       15
            //12:30am     01:00am     6       18
            //01:00am     01:30am     7       21
            //01:30am     02:00am     8       25
            //02:00am     02:30am     9       30
            //02:30am     03:00am     10      36
            //03:00am     03:30am     12      43
            //03:30am     04:00am     14      51
            //04:00am     04:30am     16      61
            //04:30am     05:00am     19      73
            //05:00am     05:30am     22      87
            //05:30am     06:00am     26      104
            //06:00am     06:30am     31      124
            //06:30am     07:00am     37      148
            //07:00am     07:30am     44      177
            //07:30am     08:00am     52      212
            //08:00am     08:30am     62      254
            //08:30am     09:00am     74      304
            //09:00am     09:30am     88      364
            //09:30am     10:00am     105     436
            //10:00am     10:30am     126     523
            //10:30am     11:00am     151     627
            //11:00am     11:30am     181     752
            //11:30am     12:00pm     217     902
            //12:00pm     12:30pm     260     1082
            //12:30pm     01:00pm     312     1298
            //01:00pm     01:30pm     260     1081
            //01:30pm     02:00pm     216     900
            //02:00pm     02:30pm     180     750
            //02:30pm     03:00pm     150     625
            //03:00pm     03:30pm     125     520
            //03:30pm     04:00pm     104     433
            //04:00pm     04:30pm     86      360
            //04:30pm     05:00pm     71      300
            //05:00pm     05:30pm     59      250
            //05:30pm     06:00pm     49      208
            //06:00pm     06:30pm     40      173
            //06:30pm     07:00pm     33      144
            //07:00pm     07:30pm     27      120
            //07:30pm     08:00pm     22      100
            //08:00pm     08:30pm     18      83
            //08:30pm     09:00pm     15      69
            //09:00pm     09:30pm     12      57
            //09:30pm     10:00pm     10      47
            //10:00pm     10:30pm     8       39
            //10:30pm     11:00pm     6       32
            //11:00pm     11:30pm     5       26
            //11:30pm     12:00pm     4       21

            return null;
        }
    }
}

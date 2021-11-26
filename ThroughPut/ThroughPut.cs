using System;
using System.Collections.Generic;

namespace RateMonitoring
{
    public interface IInterval
    {
        DateTime From { get; }
        DateTime To { get; }
        uint LowerBoundary { get; }
        uint UpperBoundary { get; }
        uint TotalThroughPut { get;}

        List<(DateTime dateOfThroughPut, uint AmountOfThroughPut)> RecordedThroughPut { get; }

        bool UpperBoundaryExceeded { get; }
        bool LowerBoundaryNotMet { get; }
    }
    public interface IThroughPut
    {
        void RecordThroughPut(uint amountOfThroughPut, DateTime dateOfThroughPut);
        event EventHandler OnUpperBoundaryExceeded;
        event EventHandler OnLowerBoundaryNotMet;
        List<IInterval> Intervals { get; }
        bool CurrentlyExceedingUpperBoundary { get; }
        bool CurrentlyMeetingLowerBoundary { get; }
    }
    //Helps make the ThroughPut class testable
    public interface IDateTime
    {
        DateTime Now();
    }
    public class ThroughPut : IThroughPut
    {
        public List<IInterval> Intervals => throw new NotImplementedException();

        public bool CurrentlyExceedingUpperBoundary => throw new NotImplementedException();

        public bool CurrentlyMeetingLowerBoundary => throw new NotImplementedException();

        public event EventHandler OnUpperBoundaryExceeded;
        public event EventHandler OnLowerBoundaryNotMet;

        public ThroughPut(List<IInterval> intervals, IDateTime dateTime)
        {

        }

        public void RecordThroughPut(uint amountOfThroughPut, DateTime dateOfThroughPut)
        {
            throw new NotImplementedException();
        }
    }
}

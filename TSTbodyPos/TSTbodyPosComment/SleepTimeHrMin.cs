using System;

namespace TSTbodyPosComment
{
    public class HoursAndMinutes
    {
        private const int NUM_RESULTS = 9;
        private const short HOUR = 3; //(short)Quantity.Multiple+1;
        private const short MIN = 3; //(short)Quantity.Multiple+1;

        private static readonly short[,] m_ResultTable = new short[HOUR, MIN];
        private static readonly string[] m_ResultsString = new string[NUM_RESULTS];
        private Quantity m_HourQuantity = Quantity.Zero;
        private int m_Hours;
        private Quantity m_MinuteQuantity = Quantity.Zero;
        private int m_Minutes;


        public HoursAndMinutes()
        {
            initializeResultsTable();
            //processQuantities();
        }

        private void processQuantities()
        {
            switch (m_Hours)
            {
                case 0:
                    m_HourQuantity = Quantity.Zero;
                    break;
                case 1:
                    m_HourQuantity = Quantity.Single;
                    break;
                default:
                    m_HourQuantity = Quantity.Multiple;
                    break;
            }

            switch (m_Minutes)
            {
                case 0:
                    m_MinuteQuantity = Quantity.Zero;
                    break;
                case 1:
                    m_MinuteQuantity = Quantity.Single;
                    break;
                default:
                    m_MinuteQuantity = Quantity.Multiple;
                    break;
            }
        }

        private static void initializeResultsTable()
        {
            //                    Hour                  Minute
            m_ResultTable[(short) Quantity.Zero, (short) Quantity.Zero] = 0;
            m_ResultTable[(short) Quantity.Zero, (short) Quantity.Single] = 1;
            m_ResultTable[(short) Quantity.Zero, (short) Quantity.Multiple] = 2;
            m_ResultTable[(short) Quantity.Single, (short) Quantity.Zero] = 3;
            m_ResultTable[(short) Quantity.Single, (short) Quantity.Single] = 4;
            m_ResultTable[(short) Quantity.Single, (short) Quantity.Multiple] = 5;
            m_ResultTable[(short) Quantity.Multiple, (short) Quantity.Zero] = 6;
            m_ResultTable[(short) Quantity.Multiple, (short) Quantity.Single] = 7;
            m_ResultTable[(short) Quantity.Multiple, (short) Quantity.Multiple] = 8;

            m_ResultsString[0] = ""; // no sleep
            m_ResultsString[1] = "1 minute";
            m_ResultsString[2] = "<MIN> minutes";
            m_ResultsString[3] = "1 hour";
            m_ResultsString[4] = "1 hour and 1 minute";
            m_ResultsString[5] = "1 hour and <MIN> minutes";
            m_ResultsString[6] = "<HR> hours";
            m_ResultsString[7] = "<HR> hours and 1 minute";
            m_ResultsString[8] = "<HR> hours and <MIN> minutes";
        }

        public string getSleepTime(double totalMinutes)
        {
            cnvrtMinsToHrsMins(out m_Minutes, out m_Hours, totalMinutes);
            processQuantities();
            var resultStr = "";
            var result = 0;

            result = m_ResultTable[(short) m_HourQuantity, (short) m_MinuteQuantity];

            resultStr = m_ResultsString[result];

            var hourStr = m_Hours.ToString();
            var minStr = m_Minutes.ToString();

            resultStr = resultStr.Replace("<HR>", hourStr);
            resultStr = resultStr.Replace("<MIN>", minStr);
            return resultStr;
        }

        private void cnvrtMinsToHrsMins(out int minutes, out int hours, double totalMinutes)
        {
            var tempValue = Math.Round(totalMinutes, 1, MidpointRounding.AwayFromZero);
            tempValue = Math.Round(tempValue, 0, MidpointRounding.AwayFromZero);
            minutes = (int) tempValue;
            hours = 0;
            // Be sure to initialize to 0

            // If our variable is greater than 60
            while (minutes > 60)
            {
                // Remove 60 from our variable
                minutes -= 60;

                // Add 1 to our hours [as 60 minutes is equivalent to one hour]
                hours++;
            }

            if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }
        }

        private enum Quantity : short
        {
            Zero,
            Single,
            Multiple
        }
    }
}
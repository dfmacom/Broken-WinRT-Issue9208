namespace Broken_WinRT.Core.Utilities.Maths;
public static class Broken_WinRTMath
{
    public static class SParameters
    {
        public static double ConvertMagToDB(double mag)
        {
            if (mag > 0)
            {
                return 20 * Math.Log10(mag);
            }
            else
            {
                return 0;
            }
        }

        public static double ConvertDBToMag(double db)
        {
            return Math.Pow(10, db / 20);
        }
    }

    public static class Power
    {
        public static double? DBMToWatts(double? dBm)
        {
            double? watts = null;
            if (dBm is not null)
            {
                watts = Math.Pow(10, dBm.Value / 10) / 1000;
            }
            return watts;
        }

        public static double? WattsToDBM(double? watts)
        {
            double? dBm = null;
            if (watts is not null)
            {
                dBm = 10 * Math.Log10(1000 * watts.Value);
            }
            return dBm;
        }
    }
}

namespace Broken_WinRT.Core.Utilities.Maths;

public static class WolfspeedMath
{

}

//public class WolfspeedMath
//{

//    public static List<double> PolynomialFit(List<double> x, List<double> y, int order)
//    {
//        var calcYValues = new List<double>();
//        if (order < x.Count)
//        {
//            double[] coeff = Fit.Polynomial(x.ToArray(), y.ToArray(), order);
//            for (var i = 0; i <= x.Count - 1; i++)
//            {
//                calcYValues.Add(Polynomial.Evaluate(x[i], coeff));
//            }
//        }
//        return calcYValues;
//    }

//    public static double CalculateSlope(List<double> x, List<double> y)
//    {
//        var xAverage = x.Average();
//        var yAverage = y.Average();
//        var xDiff = new List<double>();
//        var yDiff = new List<double>();
//        var xDiffSqr = new List<double>();
//        var top = new List<double>();
//        for (var i = 0; i < x.Count; i++)
//        {
//            xDiff.Add(x[i] - xAverage);
//            yDiff.Add(y[i] - yAverage);
//            xDiffSqr.Add(xDiff[i] * xDiff[i]);
//            top.Add(xDiff[i] * yDiff[i]);
//        }
//        return top.Sum() / xDiffSqr.Sum();
//    }

//    public static double CalculateGaussian(double x, double multipler, double average, double stdDev)
//    {
//        var v1 = (x - average) / (2d * stdDev * stdDev);
//        var v2 = -v1 * v1 / 2d;
//        var v3 = multipler * Math.Exp(v2);
//        return v3;
//    }

//    public static double CalculatePercentile(IEnumerable<double> seq, double percentile)
//    {
//        var elements = seq.ToArray();
//        Array.Sort(elements);
//        var realIndex = percentile * (elements.Length - 1);
//        var index = (int)realIndex;
//        var frac = realIndex - index;
//        if (index + 1 < elements.Length)
//            return (elements[index] * (1 - frac)) + (elements[index + 1] * frac);
//        else
//            return elements[index];
//    }

//    public static double CalculateMedian(List<double> values)
//    {
//        values = values.OrderBy(n => n).ToList();
//        var count = values.Count();
//        var midpoint = count / 2;
//        if (count % 2 == 0)
//            return (Convert.ToDouble(values.ElementAt(midpoint - 1)) + Convert.ToDouble(values.ElementAt(midpoint))) / 2.0;
//        else
//            return Convert.ToDouble(values.ElementAt(midpoint));
//    }

//    public static double CalculatePercentile(double[] sortedData, double p)
//    {
//        if (p >= 100.0d) return sortedData[sortedData.Length - 1];
//        var position = (sortedData.Length + 1) * p / 100.0;
//        double leftNumber = 0.0d, rightNumber = 0.0d;
//        var n = (p / 100.0d * (sortedData.Length - 1)) + 1.0d;
//        if (position >= 1)
//        {
//            leftNumber = sortedData[(int)Math.Floor(n) - 1];
//            rightNumber = sortedData[(int)Math.Floor(n)];
//        }
//        else
//        {
//            leftNumber = sortedData[0];
//            rightNumber = sortedData[1];
//        }

//        if (leftNumber == rightNumber)
//            return leftNumber;
//        else
//        {
//            var part = n - Math.Floor(n);
//            return leftNumber + (part * (rightNumber - leftNumber));
//        }
//    }

//    public static double CalculateStdDev(List<double> values)
//    {
//        return Math.Sqrt(values.Average(z => z * z) - Math.Pow(values.Average(), 2));
//    }

//    public static double ConvertMagAngleToRealNumber(double mag, double angle)
//    {
//        return mag * Math.Cos(angle * (Math.PI / 180.0));
//    }

//    public static double ConvertMagAngleToImagNumber(double mag, double angle)
//    {
//        return mag * Math.Sin(angle * (Math.PI / 180.0));
//    }

//    public static Complex CalculateImpedance(SparameterDataPoint data)
//    {
//        var C = new Complex(data.Real, data.Imag);
//        var one = new Complex(1, 0);
//        var Z0 = new Complex(1, 0);
//        return Z0 * ((one + C) / (one - C));
//    }

//    public static Complex CalculateImpedance(double real, double imag)
//    {
//        var C = new Complex(real, imag);
//        var one = new Complex(1, 0);
//        var Z0 = new Complex(1, 0);
//        return Z0 * ((one + C) / (one - C));
//    }

//    public static Complex CalculateGamma(double systemImpedance, double real, double imag)
//    {
//        var Z = new Complex(real, imag);
//        var Z0 = new Complex(systemImpedance, 0);
//        return (Z - Z0) / (Z + Z0);
//    }

//    public static Complex CalculateImpedance(Complex impedance)
//    {
//        var C = new Complex(impedance.Real, impedance.Imaginary);
//        var one = new Complex(1, 0);
//        var Z0 = new Complex(1, 0);
//        return Z0 * ((one + C) / (one - C));
//    }

//    public static Complex CalculateImpedance(double systemImpedance, double real, double imag)
//    {
//        var C = new Complex(real, imag);
//        var one = new Complex(1, 0);
//        var Z0 = new Complex(systemImpedance, 0);
//        return Z0 * ((one + C) / (one - C));
//    }

//    public static List<double> RemoveMinimumPoint(List<double> values)
//    {
//        return values.OrderByDescending(x => x).Take(values.Count() - 1).ToList();
//    }

//    public static double GetMinimumValue(double[] values)
//    {
//        return values.ToList().Min();
//    }

//    public static double GetMaximumValue(double[] values)
//    {
//        return values.ToList().Max();
//    }

//    public static List<double> RemoveMaximumPoint(List<double> values)
//    {
//        return values.OrderBy(x => x).Take(values.Count() - 1).ToList();
//    }

//    public static bool IsWithIn(double value, double range)
//    {
//        if (value >= value - range && value <= value + range) return true;
//        return false;
//    }

//    public static double HighestValue(double first, double last)
//    {
//        if (first > last) return first;
//        return last;
//    }

//    public static double LowestValue(double first, double last)
//    {
//        if (first < last) return first;
//        return last;
//    }

//    public static double ConvertDBMToWatts(double dBm)
//    {
//        if (dBm > 0) return Math.Pow(10, dBm / 10) / 1000;
//        else return 0;
//    }

//    public static double CalculatePae(double pin, double pout, double vds, double ids)
//    {
//        var win = Convert.ToDouble(Math.Exp(pin / 10 * 2.302585));
//        var wout = Convert.ToDouble(Math.Exp(pout / 10 * 2.302585));
//        var dcPwr = vds * (ids * 1000);
//        if (dcPwr > 0) return (wout - win) / dcPwr * 100;
//        else return 0;
//    }

//    public static double[] InvertArrayOfDoubles(double[] values)
//    {
//        return values.ToList().Select(x => x = x * -1).ToArray();
//    }

//    private static double CalculateAverageValue(int NumOfPntsToAverage, int startingIndex, double[] values)
//    {
//        double sum = 0;
//        var cnter = 0;
//        for (var i = startingIndex; i < startingIndex + NumOfPntsToAverage; i++)
//        {
//            if (i < values.Length)
//            {
//                sum += values[i];
//                cnter++;
//            }
//        }
//        return sum / cnter;
//    }

//    private static int GetStartingPointFromXValues(double time, List<double> xValues)
//    {
//        var cnter = 0;
//        foreach (var tValue in xValues)
//        {
//            if (tValue > time) return cnter;
//            cnter++;
//        }
//        return 0;
//    }

//    private static int GetIndexOfMinValue(double[] yValues)
//    {
//        return Array.IndexOf(yValues, yValues.Min());
//    }

//    public static double[] ApplySmoothingFactor(double factor, double[] values)
//    {
//        var numOfPointsToAverage = Convert.ToInt32(values.Length * (factor / 100));
//        var averagevalues = new double[values.Length];
//        for (var i = 0; i < values.Length; i++)
//        {
//            averagevalues[i] = CalculateAverageValue(numOfPointsToAverage, i, values);
//        }
//        return averagevalues;
//    }

//    public static double StandardDeviation(List<double> values)
//    {
//        var average = values.Average();
//        return Math.Sqrt(values.Average(v => Math.Pow(v - average, 2))); ;
//    }

//    public static double Slope(double x1, double y1, double x2, double y2)
//    {
//        return (y2 - y1) / (x2 - x1);
//    }

//    public static double ConvertdBmToWatts(double dbm)
//    {
//        if (dbm > 0) return Math.Pow(10, dbm / 10) / 1000;
//        return 0;
//    }

//    public static double InterpolateBewteenPoints(double xTarget, double xLow, double xHigh, double yLow, double yHigh)
//    {
//        if (xHigh - xLow == 0)
//        {
//            return (yLow + yHigh) / 2;
//        }
//        return yLow + ((xTarget - xLow) * (yHigh - yLow) / (xHigh - xLow));
//    }

//    public static Complex ConvertToComplexNumber(double real, double imag)
//    {
//        return new Complex(real, imag);
//    }
//    public static Complex ConvertToComplexNumber(double magnitude, double angle, bool degrees)
//    {
//        if (degrees) angle = angle * Math.PI / 180;
//        var real = magnitude * Math.Cos(angle);
//        var imag = magnitude * Math.Sin(angle);
//        return ConvertToComplexNumber(real, imag);
//    }
//    public static double CalculateKFactor(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double kFactor = 0;
//        var num = (s11 * s22) - (s12 * s21);
//        var dem = 2 * (s12 * s21).Magnitude;
//        kFactor = (1 + (num.Magnitude * num.Magnitude) - (s11.Magnitude * s11.Magnitude) - (s22.Magnitude * s22.Magnitude)) / dem;
//        return kFactor;
//    }

//    public static double CalculateGMax(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double gmax = 0;
//        var kFactor = CalculateKFactor(s11, s21, s12, s22);
//        if (kFactor > 1)
//        {
//            gmax = ConvertMagToDB(s21.Magnitude / s12.Magnitude * (kFactor - Math.Sqrt((kFactor * kFactor) - 1))) / 2;
//        }
//        else gmax = ConvertMagToDB(s21.Magnitude / s12.Magnitude) / 2;
//        return gmax;
//    }

//    public static double CalculateFMax(double freq, Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double fmax = 0;
//        var uGain = CalculateUnilateralGain(s11, s21, s12, s22);
//        if (uGain > -99) fmax = freq * Math.Pow(10, uGain / 20);
//        else fmax = 0;
//        return fmax;
//    }

//    private static double CalculateH21(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double h21 = 0;
//        var one = new Complex(1, 0);
//        var denom = ((one - s11) * (one + s22)) + (s12 * s21);
//        h21 = 2 * (s21 / denom).Magnitude;
//        return h21;
//    }

//    public static double CalculateFt(double freq, Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double ft = 0;
//        var h21 = ConvertMagToDB(CalculateH21(s11, s21, s12, s22));
//        if (h21 > -99) ft = freq * Math.Pow(10, h21 / 20);
//        else ft = 0;
//        return ft;
//    }

//    public static double CalculateUnilateralGain(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double uGain = 0;
//        var kFactor = CalculateKFactor(s11, s21, s12, s22);
//        var soverS = s21 / s12;
//        var num = (soverS.Magnitude - 1) * (soverS.Magnitude - 1);
//        var denum = 2 * ((kFactor * soverS.Magnitude) - soverS.Real);
//        uGain = ConvertMagToDB(num / denum) / 2;
//        return uGain;
//    }

//    public static bool Equal(double a, double b)
//    {
//        if (a >= b - 0.001 && a <= b + 0.001) return true;
//        return false;
//    }

//    public static bool Equal(double a, double b, double range)
//    {
//        if (a >= b - range && a <= b + range) return true;
//        return false;
//    }

//    public static double LinearInterpolation(double x, double x0, double x1, double y0, double y1)
//    {
//        if (x1 - x0 == 0)
//        {
//            return (y0 + y1) / 2;
//        }
//        return y0 + ((x - x0) * (y1 - y0) / (x1 - x0));
//    }

//    public static double ConvertMagToDB(double mag)
//    {
//        if (mag > 0)
//        {
//            return 20 * Math.Log10(mag);
//        }
//        else
//        {
//            return 0;
//        }
//    }

//    public static double ConvertDBToMag(double db)
//    {
//        if (db > 0)
//        {
//            return Math.Pow(10, db / 20);
//        }
//        else
//        {
//            return 0;
//        }
//    }

//    public static Complex RectToPolar(Complex c)
//    {
//        var newValue = new Complex();
//        try
//        {
//            double angle = 180;
//            var mag = Math.Sqrt((c.Real * c.Real) + (c.Imaginary * c.Imaginary));
//            if (c.Real + mag != 0) angle = 2 * Math.Atan(c.Imaginary / (c.Real + mag)) * 57.295827;
//            newValue = new Complex(mag, angle);
//        }
//        catch { }
//        return newValue;
//    }

//    public static Complex PolarToRect(Complex c)
//    {
//        var newValue = new Complex();
//        try
//        {
//            var rad = c.Imaginary / 180 * Math.PI;
//            newValue = new Complex(c.Real * Math.Cos(rad), c.Real * Math.Sin(rad));
//        }
//        catch { }
//        return newValue;
//    }

//    public static double ConvertRealAndImagToMag(double real, double imag)
//    {
//        try
//        {
//            return Math.Sqrt((real * real) + (imag * imag));
//        }
//        catch { }
//        return 0;
//    }

//    public static ImpedancePoint ConvertImpedanceToMagAngle(double systemImedance, double r, double i)
//    {
//        var impedanace = new Complex(r, i);
//        var Z = new Complex(systemImedance, 0);
//        var RI = (Z - impedanace) / (Z + impedanace);
//        var mag = ConvertRealAndImagToMag(RI.Real, RI.Imaginary);
//        var angle = ConvertRealAndImagToAngle(RI.Real, RI.Imaginary);
//        if (i > 0) angle = 180 + angle;
//        else angle = -180 + angle;
//        var real = ConvertMagAndAngleToReal(mag, angle);
//        var imag = ConvertMagAndAngleToImag(mag, angle);
//        var point = new ImpedancePoint(real, imag);
//        return point;
//    }

//    public static double ConvertRealAndImagToAngle(double real, double imag)
//    {
//        try
//        {
//            var mag = ConvertRealAndImagToMag(real, imag);
//            if (real + mag == 0) return 180;
//            else return 2 * Math.Atan(imag / (real + mag)) * 57.295827;
//        }
//        catch { }
//        return 0;
//    }

//    public static Complex ConvertToComplex(double mag, double phase)
//    {
//        double real = 0;
//        double imag = 0;
//        try
//        {
//            var rad = phase / 180 * Math.PI;
//            real = mag * Math.Cos(rad);
//            imag = mag * Math.Sin(rad);
//        }
//        catch { }
//        return new Complex(real, imag);
//    }

//    public static double ConvertMagAndAngleToReal(double mag, double phase)
//    {
//        try
//        {
//            var rad = phase / 180 * Math.PI;
//            return mag * Math.Cos(rad);
//        }
//        catch { }
//        return 0;
//    }

//    public static double ConvertMagAndAngleToImag(double mag, double phase)
//    {
//        try
//        {
//            var rad = phase / 180 * Math.PI;
//            return mag * Math.Sin(rad);
//        }
//        catch { }
//        return 0;
//    }

//    public static double ConvertToGHz(double freq)
//    {
//        if (freq < 100) return freq;
//        return Math.Round(freq / 1e9, 3);
//    }

//    public static double ConvertToHz(double freq)
//    {
//        return Math.Round(freq * 1e9);
//    }

//    public static double ConvertToMHz(double freq)
//    {
//        return Math.Round(freq * 1e6, 3);
//    }

//    public static double Convert_uS_to_Sec(double uS)
//    {
//        return uS / 1e6;
//    }

//    public static List<double> GenerateListOfDoubles(double start, double stop, double step, bool convertToGHz)
//    {
//        var list = new List<double>();
//        if (step == 0) return list;
//        var pnts = Math.Abs(Convert.ToInt32(((stop - start) / step) + 1));
//        var number = start;
//        if (convertToGHz) number = ConvertToGHz(number);
//        if (convertToGHz) step = ConvertToGHz(step);
//        for (var i = 0; i < pnts; i++)
//        {
//            list.Add(number);
//            number += step;
//        }
//        return list;
//    }

//    public static bool DoubleIsInList(double targetValue, List<double> listValues)
//    {
//        foreach (var value in listValues)
//        {
//            if (Equal(targetValue, value)) return true;
//        }
//        return false;
//    }

//    #region Fields
//    #endregion

//    #region Private Methods
//    #endregion

//    #region Public Methods

//    public static double StandardDeviation(List<double> values)
//    {
//        var average = values.Average();
//        return Math.Sqrt(values.Average(v => Math.Pow(v - average, 2))); ;
//    }

//    public static float LinearInterpolation(float x, float x0, float x1, float y0, float y1)
//    {
//        if (x1 - x0 == 0)
//        {
//            return (y0 + y1) / 2;
//        }
//        return y0 + ((x - x0) * (y1 - y0) / (x1 - x0));
//    }

//    public static double CalculateKFactor(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double kFactor = 0;
//        var num = (s11 * s22) - (s12 * s21);

//        var dem = 2 * (s12 * s21).Magnitude;
//        kFactor = (1 + (num.Magnitude * num.Magnitude) - (s11.Magnitude * s11.Magnitude) - (s22.Magnitude * s22.Magnitude)) / dem;
//        return kFactor;
//    }

//    public static double CalculateGMax(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double gmax = 0;
//        var kFactor = CalculateKFactor(s11, s21, s12, s22);
//        if (kFactor > 1)
//        {
//            gmax = ConvertMagToDB(s21.Magnitude / s12.Magnitude * (kFactor - Math.Sqrt((kFactor * kFactor) - 1))) / 2;
//        }
//        else gmax = ConvertMagToDB(s21.Magnitude / s12.Magnitude) / 2;
//        return gmax;
//    }

//    public static double CalculateFMax(double freq, Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double fmax = 0;
//        var uGain = CalculateUnilateralGain(s11, s21, s12, s22);
//        if (uGain > -99) fmax = freq * Math.Pow(10, uGain / 20);
//        else fmax = 0;
//        return fmax;
//    }

//    private static double CalculateH21(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double h21 = 0;
//        var one = new Complex(1, 0);
//        var denom = ((one - s11) * (one + s22)) + (s12 * s21);
//        h21 = 2 * (s21 / denom).Magnitude;
//        return h21;
//    }

//    public static double CalculateFt(double freq, Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double ft = 0;
//        var h21 = ConvertMagToDB(CalculateH21(s11, s21, s12, s22));
//        if (h21 > -99) ft = freq * Math.Pow(10, h21 / 20);
//        else ft = 0;
//        return ft;
//    }

//    public static double CalculateUnilateralGain(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double uGain = 0;
//        var kFactor = CalculateKFactor(s11, s21, s12, s22);
//        var soverS = s21 / s12;
//        var num = (soverS.Magnitude - 1) * (soverS.Magnitude - 1);
//        var denum = 2 * ((kFactor * soverS.Magnitude) - soverS.Real);
//        uGain = ConvertMagToDB(num / denum) / 2;
//        return uGain;
//    }

//    public static Complex ConvertToComplexNumber(double real, double imag)
//    {
//        return new Complex(real, imag);
//    }

//    public static double ConvertMagToDB(double mag)
//    {
//        if (mag > 0)
//        {
//            return Math.Log(mag) / 2.302585 * 20;
//        }
//        else
//        {
//            return 0;
//        }
//    }

//    public static double ConvertMagAngleToRealNumber(double mag, double angle)
//    {
//        return mag * Math.Cos(angle * (Math.PI / 180.0));
//    }

//    public static double ConvertMagAngleToImagNumber(double mag, double angle)
//    {
//        return mag * Math.Sin(angle * (Math.PI / 180.0));
//    }

//    public static double ConvertDBMToWatts(double dBm)
//    {
//        if (dBm > 0) return Math.Pow(10, dBm / 10) / 1000;
//        else return 0;
//    }

//    public static double ConvertDBToMag(double db)
//    {
//        try
//        {
//            return Math.Pow(10, db / 20);
//        }
//        catch { }
//        return 0;

//    }

//    public static double ConvertRealAndImagToMag(double real, double imag)
//    {
//        try
//        {
//            return Math.Sqrt((real * real) + (imag * imag));
//        }
//        catch { }
//        return 0;
//    }

//    public static double ConvertRealAndImagToAngle(double real, double imag)
//    {
//        try
//        {
//            var mag = ConvertRealAndImagToMag(real, imag);
//            if (real + mag == 0) return 180;
//            else return 2 * Math.Atan(imag / (real + mag)) * 57.295827;
//        }
//        catch { }
//        return 0;
//    }

//    public static double CalculatePae(double pin, double pout, double vds, double ids)
//    {
//        var win = Convert.ToDouble(Math.Exp(pin / 10 * 2.302585));
//        var wout = Convert.ToDouble(Math.Exp(pout / 10 * 2.302585));
//        var dcPwr = vds * (ids * 1000);
//        if (dcPwr > 0) return (wout - win) / dcPwr * 100;
//        else return 0;
//    }

//    public static List<double> RemoveMinimumPoint(List<double> values)
//    {
//        return values.OrderByDescending(x => x).Take(values.Count() - 1).ToList();
//    }

//    public static double GetMinimumValue(double[] values)
//    {
//        return values.ToList().Min();
//    }

//    public static double GetMaximumValue(double[] values)
//    {
//        return values.ToList().Max();
//    }

//    public static List<double> RemoveMaximumPoint(List<double> values)
//    {
//        return values.OrderBy(x => x).Take(values.Count() - 1).ToList();
//    }

//    public static bool IsWithIn(double value, double range)
//    {
//        if (value >= value - range && value <= value + range) return true;
//        return false;
//    }

//    public static double HighestValue(double first, double last)
//    {
//        if (first > last) return first;
//        return last;
//    }

//    public static double LowestValue(double first, double last)
//    {
//        if (first < last) return first;
//        return last;
//    }

//    public static double ConvertDBMToWatts(double dBm)
//    {
//        if (dBm > 0) return Math.Pow(10, dBm / 10) / 1000;
//        else return 0;
//    }

//    public static double CalculatePae(double pin, double pout, double vds, double ids)
//    {
//        var win = Convert.ToDouble(Math.Exp(pin / 10 * 2.302585));
//        var wout = Convert.ToDouble(Math.Exp(pout / 10 * 2.302585));
//        var dcPwr = vds * (ids * 1000);
//        if (dcPwr > 0) return (wout - win) / dcPwr * 100;
//        else return 0;
//    }
//    public static double CalculateDeff(double pout, double vds, double ids)
//    {
//        return Math.Pow(10, pout / 10) / 1000 / (vds * ids) * 100;
//    }

//    public static double[] InvertArrayOfDoubles(double[] values)
//    {
//        return values.ToList().Select(x => x = x * -1).ToArray();
//    }

//    public static void ApplyEquationToWaveform(string equation, string variable, ref double[] yValues)
//    {
//        var length = yValues.Length;
//        Expression math;
//        var firstIteration = new Stopwatch();
//        firstIteration.Start();
//        for (var i = 0; i < length; i++)
//        {
//            math = new Expression(equation.Replace(variable, yValues[i].ToString()));
//            yValues[i] = math.Solution;
//            if (i == 0) firstIteration.Stop();
//        }
//    }

//    private static double CalculateAverageValue(int NumOfPntsToAverage, int startingIndex, double[] values)
//    {
//        double sum = 0;
//        var cnter = 0;
//        for (var i = startingIndex; i < startingIndex + NumOfPntsToAverage; i++)
//        {
//            if (i < values.Length)
//            {
//                sum += values[i];
//                cnter++;
//            }
//        }
//        return sum / cnter;
//    }

//    private static int GetStartingPointFromXValues(double time, List<double> xValues)
//    {
//        var cnter = 0;
//        foreach (var tValue in xValues)
//        {
//            if (tValue > time) return cnter;
//            cnter++;
//        }
//        return 0;
//    }

//    public static void RemoveWaveformPoints(double startingTime, int storePoint, ref List<double> xValues, ref double[] yValues)
//    {
//        try
//        {
//            var count = xValues.Count;
//            var startingPoint = GetStartingPointFromXValues(startingTime, xValues);
//            var xFirst = xValues.GetRange(0, startingPoint - 1);
//            var xLast = xValues.GetRange(startingPoint, count - startingPoint);
//            var yFirst = yValues.ToList().GetRange(0, startingPoint - 1);
//            var yLast = yValues.ToList().GetRange(startingPoint, count - startingPoint);
//            xLast = xLast.Where((x, i) => i % storePoint == 0).ToList();
//            yLast = yLast.Where((x, i) => i % storePoint == 0).ToList();
//            xValues = xFirst.Concat(xLast).ToList();
//            yValues = yFirst.Concat(yLast).ToArray();
//        }
//        catch (Exception ex)
//        {
//            LogFile.Error("Unable to remove waveform points " + ex.Message);
//        }
//    }

//    private static int GetIndexOfMinValue(double[] yValues)
//    {
//        return Array.IndexOf(yValues, yValues.Min());
//    }

//    public static double CalculateRecoveryTime(List<double> xValues, double[] yValues)
//    {
//        double recoveryTime = 0;
//        try
//        {
//            var average = yValues.Select(z => z).Take(10).Average();
//            var recoveryPoutValue = average - 0.5;
//            var minValueIndex = GetIndexOfMinValue(yValues);
//            for (var i = minValueIndex; i < yValues.Length; i++)
//            {
//                var a = xValues[i];
//                if (yValues[i] >= recoveryPoutValue)
//                    return xValues[i];
//            }
//        }
//        catch (Exception ex)
//        {
//            LogFile.Error("Unable to calculate recovery time " + ex.Message);
//        }
//        return recoveryTime;
//    }

//    public static double CalculateDeltaPower(double[] yValues)
//    {
//        double deltaPower = 0;
//        try
//        {
//            var average = yValues.Select(z => z).Take(10).Average();
//            var minValue = yValues.ToList().Min();
//            deltaPower = average - minValue;
//        }
//        catch (Exception ex)
//        {
//            LogFile.Error("Unable to calculate recovery time " + ex.Message);
//        }
//        return deltaPower;
//    }

//    public static double[] ApplySmoothingFactor(double factor, double[] values)
//    {
//        var numOfPointsToAverage = Convert.ToInt32(values.Length * (factor / 100));
//        var averagevalues = new double[values.Length];
//        for (var i = 0; i < values.Length; i++)
//        {
//            averagevalues[i] = CalculateAverageValue(numOfPointsToAverage, i, values);
//        }
//        return averagevalues;
//    }

//    public static Complex CalculateImpedance(NWATracePoint data)
//    {
//        var C = new Complex(data.Real, data.Imag);
//        var one = new Complex(1, 0);
//        var Z0 = new Complex(1, 0);
//        return Z0 * ((one + C) / (one - C));
//    }

//    public static Complex CalculateImpedance(double real, double imag)
//    {
//        var C = new Complex(real, imag);
//        var one = new Complex(1, 0);
//        var Z0 = new Complex(1, 0);
//        return Z0 * ((one + C) / (one - C));
//    }

//    public static Complex CalculateImpedance(double systemImpedance, double real, double imag)
//    {
//        var C = new Complex(real, imag);
//        var one = new Complex(1, 0);
//        var Z0 = new Complex(systemImpedance, 0);
//        return Z0 * ((one + C) / (one - C));
//    }

//    public static Complex CalculateS21Impedance(NWATracePoint s11, NWATracePoint s21, NWATracePoint s22)
//    {
//        var S11C = new Complex(s11.Real, s11.Imag);
//        var S22C = new Complex(s22.Real, s22.Imag);
//        var S21C = new Complex(s21.Real, s21.Imag);
//        var one = new Complex(1, 0);
//        var two = new Complex(2, 0);
//        var Z0 = new Complex(1, 0);
//        var denom = (one - S11C) * (one - S22C);
//        var R1 = two * S21C / denom;
//        return Z0 * R1;
//    }

//    public static Complex CalculateS12Impedance(NWATracePoint s11, NWATracePoint s12, NWATracePoint s22)
//    {
//        var S11C = new Complex(s11.Real, s11.Imag);
//        var S22C = new Complex(s22.Real, s22.Imag);
//        var S12C = new Complex(s12.Real, s12.Imag);
//        var one = new Complex(1, 0);
//        var two = new Complex(2, 0);
//        var Z0 = new Complex(1, 0);
//        var denom = (one - S11C) * (one - S22C);
//        var R1 = two * S12C / denom;
//        return Z0 * R1;
//    }

//    public static Complex CalculateS22Impedance(NWATracePoint s11, NWATracePoint s22)
//    {
//        var S11C = new Complex(s11.Real, s11.Imag);
//        var S22C = new Complex(s22.Real, s22.Imag);
//        var one = new Complex(1, 0);
//        var Z0 = new Complex(1, 0);
//        var denom = (one - S11C) * (one - S22C);
//        var R1 = (one - S11C) * (one + S22C);
//        var R2 = R1 / denom;
//        return Z0 * R2;
//    }

//    public static double StandardDeviation(List<double> values)
//    {
//        var average = values.Average();
//        return Math.Sqrt(values.Average(v => Math.Pow(v - average, 2))); ;
//    }

//    public static double Slope(double x1, double y1, double x2, double y2)
//    {
//        return (y2 - y1) / (x2 - x1);
//    }

//    public static double ConvertdBmToWatts(double dbm)
//    {
//        if (dbm > 0) return Math.Pow(10, dbm / 10) / 1000;
//        return 0;
//    }

//    public static double InterpolateBewteenPoints(double xTarget, double xLow, double xHigh, double yLow, double yHigh)
//    {
//        if (xHigh - xLow == 0)
//        {
//            return (yLow + yHigh) / 2;
//        }
//        return yLow + ((xTarget - xLow) * (yHigh - yLow) / (xHigh - xLow));
//    }

//    public static Complex ConvertToComplexNumber(double real, double imag)
//    {
//        return new Complex(real, imag);
//    }
//    public static Complex ConvertToComplexNumber(double magnitude, double angle, bool degrees)
//    {
//        if (degrees) angle = angle * Math.PI / 180;
//        var real = magnitude * Math.Cos(angle);
//        var imag = magnitude * Math.Sin(angle);
//        return ConvertToComplexNumber(real, imag);
//    }
//    public static double CalculateKFactor(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double kFactor = 0;
//        var num = (s11 * s22) - (s12 * s21);

//        var dem = 2 * (s12 * s21).Magnitude;
//        kFactor = (1 + (num.Magnitude * num.Magnitude) - (s11.Magnitude * s11.Magnitude) - (s22.Magnitude * s22.Magnitude)) / dem;
//        return kFactor;
//    }

//    public static double CalculateGMax(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double gmax = 0;
//        var kFactor = CalculateKFactor(s11, s21, s12, s22);
//        if (kFactor > 1)
//        {
//            gmax = ConvertMagToDB(s21.Magnitude / s12.Magnitude * (kFactor - Math.Sqrt((kFactor * kFactor) - 1))) / 2;
//        }
//        else gmax = ConvertMagToDB(s21.Magnitude / s12.Magnitude) / 2;
//        return gmax;
//    }

//    public static double CalculateFMax(double freq, Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double fmax = 0;
//        var uGain = CalculateUnilateralGain(s11, s21, s12, s22);
//        if (uGain > -99) fmax = freq * Math.Pow(10, uGain / 20);
//        else fmax = 0;
//        return fmax;
//    }

//    private static double CalculateH21(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double h21 = 0;
//        var one = new Complex(1, 0);
//        var denom = ((one - s11) * (one + s22)) + (s12 * s21);
//        h21 = 2 * (s21 / denom).Magnitude;
//        return h21;
//    }

//    public static double CalculateFt(double freq, Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double ft = 0;
//        var h21 = ConvertMagToDB(CalculateH21(s11, s21, s12, s22));
//        if (h21 > -99) ft = freq * Math.Pow(10, h21 / 20);
//        else ft = 0;
//        return ft;
//    }

//    public static double CalculateUnilateralGain(Complex s11, Complex s21, Complex s12, Complex s22)
//    {
//        double uGain = 0;
//        var kFactor = CalculateKFactor(s11, s21, s12, s22);
//        var soverS = s21 / s12;
//        var num = (soverS.Magnitude - 1) * (soverS.Magnitude - 1);
//        var denum = 2 * ((kFactor * soverS.Magnitude) - soverS.Real);
//        uGain = ConvertMagToDB(num / denum) / 2;
//        return uGain;
//    }

//    public static bool Equal(double a, double b)
//    {
//        if (a >= b - 0.001 && a <= b + 0.001) return true;
//        return false;
//    }

//    public static bool Equal(double a, double b, double range)
//    {
//        if (a >= b - range && a <= b + range) return true;
//        return false;
//    }

//    public static double LinearInterpolation(double x, double x0, double x1, double y0, double y1)
//    {
//        if (x1 - x0 == 0)
//        {
//            return (y0 + y1) / 2;
//        }
//        return y0 + ((x - x0) * (y1 - y0) / (x1 - x0));
//    }

//    public static double ConvertMagToDB(double mag)
//    {
//        if (mag > 0)
//        {
//            return 20 * Math.Log10(mag);
//        }
//        else
//        {
//            return 0;
//        }
//    }

//    public static double ConvertDBToMag(double db)
//    {
//        if (db > 0)
//        {
//            return Math.Log(db) * 20;
//        }
//        else
//        {
//            return 0;
//        }
//    }

//    public static double ConvertRealAndImagToMag(double real, double imag)
//    {
//        try
//        {
//            return Math.Sqrt((real * real) + (imag * imag));
//        }
//        catch { }
//        return 0;
//    }

//    public static double ConvertRealAndImagToAngle(double real, double imag)
//    {
//        try
//        {
//            var mag = ConvertRealAndImagToMag(real, imag);
//            if (real + mag == 0) return 180;
//            else return 2 * Math.Atan(imag / (real + mag)) * 57.295827;
//        }
//        catch { }
//        return 0;
//    }

//    public static double ConvertMagAndAngleToReal(double mag, double phase)
//    {
//        try
//        {
//            var rad = phase / 180 * Math.PI;
//            return mag * Math.Cos(rad);
//        }
//        catch { }
//        return 0;
//    }

//    public static double ConvertMagAndAngleToImag(double mag, double phase)
//    {
//        try
//        {
//            var rad = phase / 180 * Math.PI;
//            return mag * Math.Sin(rad);
//        }
//        catch { }
//        return 0;
//    }

//    public static double ConvertToGHz(double freq)
//    {
//        if (freq < 100) return freq;
//        return Math.Round(freq / 1e9, 3);
//    }

//    public static double ConvertToHz(double freq)
//    {
//        return Math.Round(freq * 1e9);
//    }

//    public static double ConvertToMHz(double freq)
//    {
//        return Math.Round(freq * 1e6, 3);
//    }

//    public static double Convert_uS_to_Sec(double uS)
//    {
//        return uS / 1e6;
//    }

//    public static List<double> GenerateListOfDoubles(double start, double stop, double step, bool convertToGHz)
//    {
//        var list = new List<double>();
//        if (step == 0) return list;
//        var pnts = Math.Abs(Convert.ToInt32(((stop - start) / step) + 1));
//        var number = start;
//        if (convertToGHz) number = ConvertToGHz(number);
//        if (convertToGHz) step = ConvertToGHz(step);
//        for (var i = 0; i < pnts; i++)
//        {
//            list.Add(number);
//            number += step;
//        }
//        return list;
//    }

//    public static bool DoubleIsInList(double targetValue, List<double> listValues)
//    {
//        foreach (var value in listValues)
//        {
//            if (Equal(targetValue, value)) return true;
//        }
//        return false;
//    }

//    public static string OrdinalSuffix(int i)
//    {
//        if (i % 100 > 13 || i % 100 < 11)
//        {
//            switch (i % 10)
//            {
//                case 1:
//                    return "st";
//                case 2:
//                    return "nd";
//                case 3:
//                    return "rd";
//            }
//        }
//        return "th";
//    }
//    #endregion
//}

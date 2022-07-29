
namespace MyLib
{
    public abstract class PercentCalculationProgress : ProgressBar
    {
        int step = 5;
        public PercentCalculationProgress(int MaxCount) : base(MaxCount) { }
        public int Percent { get { return LinesCount * step; } }
    }
}

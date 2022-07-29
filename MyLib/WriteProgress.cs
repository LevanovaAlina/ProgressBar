
namespace MyLib
{
    sealed public class WritePercentProgress : PercentCalculationProgress
    {
        public WritePercentProgress(int MaxCount) : base(MaxCount) { }
        public override void WorkProgress()
        {
            base.WorkProgress();
            Console.WriteLine("Выполнено: {0}%", Percent);
        }
    }
}

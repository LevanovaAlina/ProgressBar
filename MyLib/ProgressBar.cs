
namespace MyLib
{
   public class ProgressBar : Progress
    {
        public ProgressBar(int MaxCount) : base(MaxCount) { }
        protected int MaxLengthLine = 20;
        public string ProgressLine = "[                    ]";
        public int LinesCount;
        public int CurrentLinesCount { get { return (int)(CurrentCount / MaxCount * MaxLengthLine); } }
        public override void WorkProgress()
        {
            Console.Clear();
            for (int i = 1; i <= LinesCount; i++)
                ProgressLine = ProgressLine.Remove(i, 1).Insert(i, "|");
            Console.WriteLine(ProgressLine);
        }
    }
}

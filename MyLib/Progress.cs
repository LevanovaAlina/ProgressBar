namespace MyLib
{
    public abstract class Progress
    {
        public int MaxCount { get; }
        public double CurrentCount { get; set; }
        public Progress(int maxCount)
        {
            MaxCount = maxCount;
        }

        public abstract void WorkProgress();
    }

}
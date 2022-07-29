using MyLib;
public class Program
{
    private static void Main()
    {
        WritePercentProgress progressConsole = new WritePercentProgress(100);
        for(int i = 0; i <= progressConsole.MaxCount; i++)
        {
            progressConsole.CurrentCount = i;
            if (progressConsole.LinesCount != progressConsole.CurrentLinesCount)
            {
                progressConsole.LinesCount = progressConsole.CurrentLinesCount;
                progressConsole.WorkProgress();
                Thread.Sleep(300);
            }
        }
    }
}
public class RunningTotalFilter
{
    public static int[] RunningTotals(int[] xs)
    {
        int[] result = new int[xs.Length];
        int sum = 0;
        for (int i = 0; i < xs.Length; i++)
        {
            sum += xs[i];
            result[i] += sum;
        }
        return result;
    }
}
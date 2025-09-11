namespace Tyuiu.DolganovAV.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] NumOne, int[] NumTwo)
        {
            int[] resultArray = new int[5];
            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = NumOne[i] + NumTwo[i];
            }
            return resultArray;
        }
    }
}

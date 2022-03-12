public class i111_09_p17
{
    public static void Main()
    {
        int[] data = new int[] { 65, 12, 46, 97, 56, 33, 75, 53, 21 };
        print(data);

        int n = data.Length;
        for (int gap = n / 2; gap > 0; gap = gap / 2)
        {
            for (int i = gap; i < n; i++)
            {
                System.Console.WriteLine("i= "+i);
                for (int j = i - gap; j >= 0 && data[j] > data[j + gap]; j = j - gap, System.Console.WriteLine(j))
                {
                    System.Console.WriteLine("i, j, gap =  "+i+" "+j+" "+gap);
                    int t = data[j]; data[j] = data[j + gap]; data[j + gap] = t;
                }
            }
            print(data);
        }
    }

    public static void print(int[] ar)
    {
        for (int i = 0; i < ar.Length; i++) System.Console.Write(ar[i] + " ");
        System.Console.WriteLine();
    }
}

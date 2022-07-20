using System;

class NumberStore
{
    int[] numbers = { 1, 3, 7, 15, 31, 63, 127, 255, 511, 1023 };

    public ref int FindNumber(int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= target)
                return ref numbers[i];
        }
        return ref numbers[0];
    }

    public override string ToString() => string.Join(" ", numbers);
}
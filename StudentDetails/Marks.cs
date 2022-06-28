namespace StudentDetails
{
    public class Marks
    {
        public int MathsMarks { get; }
        public int ScienceMarks { get; }
        public int PhysicsMarks { get; }
        public int HistoryMarks { get; }
        public int GeographyMarks { get; }

        public Marks(int mathMarks, int scienceMarks, int physicsMarks, int historyMarks, int geograpgyMarks)
        {
            MathsMarks = mathMarks;
            ScienceMarks = scienceMarks;
            PhysicsMarks = physicsMarks;
            HistoryMarks = historyMarks;
            GeographyMarks = geograpgyMarks;
        }
        public int CalculateTotalMarks()
        {
            return MathsMarks + ScienceMarks + PhysicsMarks + HistoryMarks + GeographyMarks;
        }

        public decimal CalulatePercentageMarks()
        {
            return CalulatePercentageMarks() / 500;
        }
        public char CalculateGrade()
        {
            decimal percentage = CalulatePercentageMarks();

            if (percentage > 90)
                return 'A';
            else if (percentage < 90 && percentage > 75)
                return 'B';
            else if (percentage < 75 && percentage > 60)
                return 'C';
            else if (percentage < 60 && percentage > 40)
                return 'D';
            else
                return 'F';

        }

    }
}

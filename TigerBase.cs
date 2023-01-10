namespace ConsoleApp_Exam.Exercise_2
{
    internal class TigerBase
    {
        public override void SetMe(string weight, string name)
        {
            name = "Tiger";
            weight = "100";
        }

        public override string Show()
        {
            return ("Name: " + name + "," + "Weight: " + weight);
        }
    }
}
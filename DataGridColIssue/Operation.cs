
namespace DataGridColIssue
{
    public class Operation
    {
        public bool Exclude { get; set; }
        public int Number { get; set; }

        public Operation(int Number)
        {
            this.Number = Number;
        }
    }
}

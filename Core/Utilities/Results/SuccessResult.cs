namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message) // Base kalıtım aldığı class
        {

        }

        public SuccessResult() : base(true)
        {

        }
    }
}

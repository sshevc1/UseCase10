using System.Text.RegularExpressions;

namespace UseCase10
{
    public class StringEvaluator
    {
        public bool ValidateString(string input, int maxLength)
        {
            string regexPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!""#$%&'()*+,-.\/:;<=>?@\\\\[\\\]^_`{|}~])(?!.*\s).{1," + maxLength + "}$";
            Regex regex = new Regex(regexPattern);
            return regex.IsMatch(input);
        }
    }
}
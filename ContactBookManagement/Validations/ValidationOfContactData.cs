using System.Text.RegularExpressions;

namespace ContactBookManagement.Validations
{
    public class ValidationOfContactData
    {
        private readonly Regex _reg;
        public ValidationOfContactData()
        {
            _reg = new Regex("\\A[^\\W\\d_]+\\z");
        }
        public bool ValidatingOfStringData(string data)
        {
            if (!_reg.Match(data).Success)
                return false;
            return true;
        }
    }
}

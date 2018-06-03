namespace breif_4_unit_tests
{
    public class BusinessLogic
    {
        private readonly int _firstNumber;
        private readonly int _secondNumber;

        public BusinessLogic(int firstNumber, int secondNumber )
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }
       
        public int CalculateSum()
        {
            return _firstNumber + _secondNumber + _secondNumber;
        }
        
        public int CalculateMultiplication()
        {
            return CalculateSum();
        }

    }
}

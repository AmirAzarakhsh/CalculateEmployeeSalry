

namespace ObjectOrientedTask1.Validators
{
    public static class  NationalCodeValidator 
    {
        public  static  bool validate(string NationalCode)
        {
           
            if (string.IsNullOrWhiteSpace(NationalCode)  ||  NationalCode.Length != 10  ||  !NationalCode.All(char.IsDigit))
                return false;
            else
            {
                int[] weights = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int sum = 0;

                for (int i = 0; i < 9; i++)
                {
                    sum += (NationalCode[i] - '0') * weights[i];
                }

                int remainder = sum % 11;

                int checkDigit = NationalCode[9] - '0';

                return (remainder < 2 && checkDigit == remainder) || (remainder >= 2 && checkDigit == 11 - remainder);
                
            }
            
        }
    }
}

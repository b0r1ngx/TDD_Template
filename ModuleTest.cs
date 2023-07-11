namespace TDD_Template
{
    public class ModuleTest
    {
        Module module = new();

        public Boolean specialOperationTest()
        {
            int a = 5;
            int b = 6;
            int result = module.specialOperation(a, b);
            return result == (a + b) << 2;
        }

        public Boolean moduleOverHeatTest()
        {
            float temperature = 40.1f;
            return module.isModuleOverHeat(temperature);
        }

        public Boolean tooMuchNumbersAfterDotTest()
        {
            float firstNumber = 0.00007f;
            float secondNumber = 0.00000000000000000000000000000000000000000000000000000000000000000000000000000000001f;

            float expectedResult = 0.00007000000000000000000000000000000000000000000000000000000000000000000000000000001f;
            float actualResult = module.checkProcessorNumbersSum(firstNumber, secondNumber);

            return expectedResult == actualResult;
        }
    }
}
using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseOperations
{
    [TestClass]
    public class BaseOperations
    {
        [TestMethod]
        public void Transform1FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new byte[] { 1 }, TransformFromBaseTenToAnotherBase(1,2));
        }
        [TestMethod]
        public void Transform2FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, TransformFromBaseTenToAnotherBase(2,2));
        }
        [TestMethod]
        public void Transform15FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0 }, TransformFromBaseTenToAnotherBase(16,2));
        }
        [TestMethod]
        public void Transform260FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0, 0, 1, 0, 0 }, TransformFromBaseTenToAnotherBase(260,2));
        }
        [TestMethod]
        public void InvertArray123()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 2, 1 }, InvertArray(new byte[] { 1, 2, 3 }));
        }
        [TestMethod]
        public void OROperation()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, BitOperation(TransformFromBaseTenToAnotherBase(1,2), TransformFromBaseTenToAnotherBase(2,2), "OR"));
        }
        [TestMethod]
        public void OROperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1 }, BitOperation(TransformFromBaseTenToAnotherBase(7,2), TransformFromBaseTenToAnotherBase(9,2), "OR"));
        }
        [TestMethod]
        public void ANDOperation()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0 }, BitOperation(TransformFromBaseTenToAnotherBase(1,2), TransformFromBaseTenToAnotherBase(2,2), "AND"));
        }
        [TestMethod]
        public void ANDOperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1 }, BitOperation(TransformFromBaseTenToAnotherBase(7,2), TransformFromBaseTenToAnotherBase(9,2), "AND"));
        }
        [TestMethod]
        public void XOROperation()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, BitOperation(TransformFromBaseTenToAnotherBase(1,2), TransformFromBaseTenToAnotherBase(2,2), "XOR"));
        }
        [TestMethod]
        public void XOROperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 0 }, BitOperation(TransformFromBaseTenToAnotherBase(7,2), TransformFromBaseTenToAnotherBase(9,2), "XOR"));
        }
        [TestMethod]
        public void AddNulltoATwoElementsArrayIfIIsFive()
        {
            Assert.AreEqual(0, GetNullIfOutOfArrayRange(new byte[] { 1, 0 }, 5));
        }
        [TestMethod]
        public void AddNulltoAOneElementsArrayIfIIsOne()
        {
            Assert.AreEqual(0, GetNullIfOutOfArrayRange(new byte[] { 1 }, 1));
        }
        [TestMethod]
        public void AddValueToATwoElementsArrayIfIIsNull()
        {
            Assert.AreEqual(0, GetNullIfOutOfArrayRange(new byte[] { 1, 0 }, 0));
        }
        [TestMethod]
        public void ShouldReturnThirdElementFromRightSideFromSixElementArray()
        {
            Assert.AreEqual(1, GetNullIfOutOfArrayRange(new byte[] { 1, 0, 0, 1, 0, 0 }, 2));
        }
        [TestMethod]
        public void ShouldReturnSecondElementFromRightSideFromFourElementArray()
        {
            Assert.AreEqual(1, GetNullIfOutOfArrayRange(new byte[] { 1, 0, 1, 0 }, 1));
        }
        [TestMethod]
        public void NOTOperation()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1 }, NotOperation(TransformFromBaseTenToAnotherBase(2,2)));
        }
        [TestMethod]
        public void AddZeroValueToOneElementArray()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1 }, AddZeroValuesToArrayUntilSpecifiedLength(new byte[] { 1 }, 2));
        }
        [TestMethod]
        public void AddFiveZeroValueToOneElementArray()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 1 }, AddZeroValuesToArrayUntilSpecifiedLength(new byte[] { 1 }, 6));
        }
        [TestMethod]
        public void AddZeroValueTotwoElementArray()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 0, 1, 0 }, AddZeroValuesToArrayUntilSpecifiedLength(TransformFromBaseTenToAnotherBase(2,2), 8));
        }
        [TestMethod]
        public void ShiftToLeftTwoValueArray()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 0, 0, 0 }, ShiftArray(TransformFromBaseTenToAnotherBase(2,2), 2, "LEFT"));
        }
        [TestMethod]
        public void ShiftToLeftFourValuesArray()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 1, 0, 0, 0, 0 }, ShiftArray(new byte[] { 1, 0, 1, 0 }, 3, "LEFT"));
        }
        [TestMethod]
        public void ShiftToRightTwoValueArrayTwoElements()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, ShiftArray(TransformFromBaseTenToAnotherBase(2,2), 2, "RIGHT"));
        }
        [TestMethod]
        public void ShiftToRightFourValuesArrayTwoSteps()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 0, 1, 0 }, ShiftArray(new byte[] { 1, 0, 1, 0 }, 2, "RIGHT"));
        }
        [TestMethod]
        public void ShouldReturnEightIfArrayLengthIsSmallerThenEight()
        {
            Assert.AreEqual(8, ReturnArrayLengthEightSixteenThirtytwoAndSoOn(3));
        }
        public void ShouldReturnSixteenIfArrayLengthIsBiggerThenEightAndSmallerThenSixteen()
        {
            Assert.AreEqual(16, ReturnArrayLengthEightSixteenThirtytwoAndSoOn(9));
        }
        [TestMethod]
        public void CompareIfOneBasetwoIsGreaterThenTwoBaseTwo()
        {
            Assert.IsFalse(CompareIfAGreaterThenB(new byte[] { 1 }, new byte[] { 1, 0 }));
        }
        [TestMethod]
        public void ShouldReturnFalseForFirsArrayLengthSmallerThenSecond()
        {
            Assert.IsFalse(CompareIfAGreaterThenB(new byte[] { 1, 5 }, new byte[] { 3, 4, 1 }));
        }
        [TestMethod]
        public void CompareIfOneBasetwoIsSmallerThenTwoBaseTwo()
        {
            Assert.IsTrue(CompareIfASmallerThenB(new byte[] { 1 }, new byte[] { 1, 0 }));
        }
        [TestMethod]
        public void ShouldReturnFalseForFirsArrayLengthBiggerThenSecond()
        {
            Assert.IsTrue(CompareIfASmallerThenB(new byte[] { 1, 5 }, new byte[] { 3, 4, 1 }));
        }
        [TestMethod]
        public void CompareIfOneBasetwoIsEqualThenTwoBaseTwo()
        {
            Assert.IsTrue(CompareIfAEqualB(new byte[] { 1, 0 }, new byte[] { 1, 0 }));
        }
        [TestMethod]
        public void ShouldReturnFalseForFirsArrayLengthEqualThenSecond()
        {
            Assert.IsFalse(CompareIfAEqualB(new byte[] { 1, 5 }, new byte[] { 3, 4, 1 }));
        }
        [TestMethod]
        public void AspectedTwoAfterCountingFirstNullValues()
        {
            Assert.AreEqual(2, CountFirstNullValues(new byte[] { 0, 0, 1, 0 }));
        }
        [TestMethod]
        public void ReduceArrayByDeletingFirstTwoNullValues()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, CutFirstNullValues(new byte[] { 0, 0, 1, 0 }));
        }
        [TestMethod]
        public void AddBaseTwoNumbers()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, AddingNumbersInBaseX(new byte[] { 1 }, new byte[] { 1, 0 }, 2));
        }
        [TestMethod]
        public void AddBaseTenNumbers()
        {
            CollectionAssert.AreEqual(new byte[] { 4, 2 }, AddingNumbersInBaseX(new byte[] { 7 }, new byte[] { 3, 5 }, 10));
        }
        [TestMethod]
        public void AddBaseSixNumbers()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 5, 3, 3, 4 }, AddingNumbersInBaseX(new byte[] { 3, 4, 5, 2, 1 }, new byte[] { 4, 1, 3 }, 6));
        }
        [TestMethod]
        public void ShouldIncreaseResultArrayAddingBaseTwoNumbers()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0 }, AddingNumbersInBaseX(new byte[] { 1, 0, 1, 1 }, new byte[] { 1, 0, 1 }, 2));
        }
        [TestMethod]
        public void SubstractBaseTwoNumbers()
        {
            CollectionAssert.AreEqual(new byte[] { 1 }, SubstractionNumbersInBaseX(new byte[] { 1, 0 }, new byte[] { 1 }, 2));
        }
        [TestMethod]
        public void SubstractBaseTwoNumbersSecondIsBigger()
        {
            CollectionAssert.AreEqual(new byte[] { 1 }, SubstractionNumbersInBaseX(new byte[] { 1 }, new byte[] { 1, 0 }, 2));
        }
        [TestMethod]
        public void SubstractSeventeenFromThirtysevenBaseTwo()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0, 0 }, SubstractionNumbersInBaseX(new byte[] { 0, 0, 1, 0, 0, 1, 0, 1 }, new byte[] { 0, 0, 0, 1, 0, 0, 0, 1 }, 2));
        }
        [TestMethod]
        public void SubstractSeventeenFromThirtysevenBaseTwoWithFunction()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0, 0 }, SubstractionNumbersInBaseX(TransformFromBaseTenToAnotherBase(37,2), TransformFromBaseTenToAnotherBase(17,2), 2));
        }
        [TestMethod]
        public void SubstractSeventeenFromThirtysevenBaseTenWithFunction()
        {
            CollectionAssert.AreEqual(new byte[] { 2, 0 }, SubstractionNumbersInBaseX(new byte[] { 1, 7 }, new byte[] { 3, 7 }, 10));
        }
        [TestMethod]
        public void SubstractInBaseSix()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 2, 2 }, SubstractionNumbersInBaseX(new byte[] { 1, 5 }, new byte[] { 3, 4, 1 }, 6));
        }
        [TestMethod]
        public void ShouldTestIfResultIsOkForTwoBinaryMultiplication()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, MultiplyInSelectedBase(new byte[] { 1, 0 }, new byte[] { 1 }, 2));
        }
        [TestMethod]
        public void ShouldReturnFourInBaseTwoForTwoBinaryMultiplicateWithTwo()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, MultiplyInSelectedBase(new byte[] { 1, 0 }, new byte[] { 1, 0 }, 2));
        }
        [TestMethod]
        public void ShouldReturnResultOfTwoBinaryMultiplication()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 1, 1, 1 }, MultiplyInSelectedBase(new byte[] { 1, 0, 1 }, new byte[] { 1, 0, 1, 1 }, 2));
        }
        [TestMethod]
        public void ShouldReturnFifteenAftrMultiplicationOfFiveAndThreeBaseTen()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 5 }, MultiplyInSelectedBase(new byte[] { 3 }, new byte[] { 5 }, 10));
        }
        [TestMethod]
        public void ShouldReturnFourAfterMultiplicationOfTwoAndTwoBaseTwo()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0 }, MultiplyInSelectedBase(new byte[] { 1, 0, 0 }, new byte[] { 1, 0 }, 2));
        }
        [TestMethod]
        public void ShouldReturnTwoInBaseTwoWhenDevideFourWithTwoBinary()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, DevideInDesiredBase(new byte[] { 1, 0, 0 }, new byte[] { 1, 0 }, 2));
        }
        [TestMethod]
        public void ShouldReturnTenInBaseTenWhenDevideOneHunderdWithTen()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, DevideInDesiredBase(new byte[] { 1, 0, 0 }, new byte[] { 1, 0 }, 10));
        }
        [TestMethod]
        public void ShouldIncreaseArrayWithOneAndAddNullValueAtEnd()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, AddNullAtTheEnd(new byte[] { 1, 0, 1 }));
        }
        [TestMethod]
        public void ReturnTransformationOfTwoFromBaseTenToBaseTwo()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, TransformFromBaseTenToAnotherBase(2, 2));
        }
        [TestMethod]
        public void ReturnTransformationOfTwentySixFromBaseTenToBaseSix()
        {
            CollectionAssert.AreEqual(new byte[] { 4, 2 }, TransformFromBaseTenToAnotherBase(26, 6));
        }
        [TestMethod]
        public void ReturnTransformationOfTwoFromBaseTwoToBaseTen()
        {
            Assert.AreEqual(2, TransformFromAnyBaseToBaseTen(TransformFromBaseTenToAnotherBase(2, 2),2));
        }
        [TestMethod]
        public void ReturnTransformationOfSeventeenFromBaseTwoToBaseTen()
        {
            Assert.AreEqual(17, TransformFromAnyBaseToBaseTen(TransformFromBaseTenToAnotherBase(17, 2), 2));
        }
        [TestMethod]
        public void ReturnTransformationOfTwentySixFromBaseTwoToBaseSix()
        {
            CollectionAssert.AreEqual(new byte[] { 4, 2 }, TransformFromAnyBaseToAnyBase(TransformFromBaseTenToAnotherBase(26,2), 2, 6));
        }


        byte[] TransformFromAnyBaseToAnyBase(byte[] array, int firstBase, int secondBase)
        {
           return TransformFromBaseTenToAnotherBase(TransformFromAnyBaseToBaseTen(array,firstBase),secondBase);
        }
        byte[] TransformFromBaseTenToAnotherBase(int number, int baseNumber)
        {
            byte[] baseArray = { };
            while (number > 0)
            {
                Array.Resize(ref baseArray, baseArray.Length + 1);
                baseArray[baseArray.Length - 1] = (byte)(number % baseNumber);
                number = number / baseNumber;
            }
            return InvertArray(baseArray);
        }
        int TransformFromAnyBaseToBaseTen(byte[] arrayNumber, int baseNumber)
        {
            int result = 0;
            for (int i = arrayNumber.Length-1; i >= 0; i--)
            {
                result = result + arrayNumber[i] * (int) Math.Pow(baseNumber, arrayNumber.Length - 1 - i);
            }
             return result;
        }
        public byte[] InvertArray(byte[] array)
        {
            byte[] invertedArray = new byte[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                invertedArray[i] = array[array.Length - 1 - i];
            }
            return invertedArray;
        }

        public byte[] BitOperation(byte[] v1, byte[] v2, string operation)
        {
            int arrayLength = Math.Max(v1.Length, v2.Length);
            byte[] result = new byte[arrayLength];
            for (int i = arrayLength - 1; i >= 0; i--)
            {
                result[i] = ReturnBiteValueForSelectedOperation(GetNullIfOutOfArrayRange(v1, arrayLength - 1 - i), GetNullIfOutOfArrayRange(v2, arrayLength - 1 - i), operation, i);
            }
            return result;
        }

        byte ReturnBiteValueForSelectedOperation(byte v1, byte v2, string Operation, int i)
        {
            switch (Operation)
            {
                case "OR":
                    return v1 == (byte)1 || v2 == (byte)1 ? (byte)1 : (byte)0;
                case "AND":
                    return v1 == (byte)1 && v2 == (byte)1 ? (byte)1 : (byte)0;
                case "XOR":
                    return v1 == v2 ? (byte)0 : (byte)1;
                default:
                    return 0;
            }
        }

        byte GetNullIfOutOfArrayRange(byte[] array, int i)
        {
            return (i < (array.Length)) && i >= 0 ? array[array.Length - 1 - i] : (byte)0;
        }
        byte[] NotOperation(byte[] notArray)
        {
            byte[] notResult = new byte[notArray.Length];
            for (int i = 0; i < notArray.Length; i++)
            {
                notResult[i] = notArray[i] == (byte)0 ? (byte)1 : (byte)0;
            }
            return notResult;
        }


        private byte[] AddZeroValuesToArrayUntilSpecifiedLength(byte[] arrayToModify, int arrayDesiredLength)
        {
            byte[] invertedArray = InvertArray(arrayToModify);
            while (invertedArray.Length < arrayDesiredLength)
            {
                Array.Resize(ref invertedArray, invertedArray.Length + 1);
                invertedArray[invertedArray.Length - 1] = 0;
            }
            return InvertArray(invertedArray);
        }
        byte[] ShiftArray(byte[] toBeShifted, int steps, string direction)
        {
            byte[] shiftedResult = new byte[ReturnArrayLengthEightSixteenThirtytwoAndSoOn(toBeShifted.Length)];
            for (int i = shiftedResult.Length - 1; i >= 0; i--)
            {
                shiftedResult[i] = GetNullIfOutOfArrayRange(toBeShifted, shiftedResult.Length - 1 - i + ChoseLeftOrRight(direction, steps));
            }
            return shiftedResult;
        }

        int ChoseLeftOrRight(string direction, int steps)
        {
            return direction == "LEFT" ? 0 - steps : steps;
        }

        int ReturnArrayLengthEightSixteenThirtytwoAndSoOn(int length)
        {
            for (int i = 3; ; i++)
            {
                if (length <= Math.Pow(2, i))
                {
                    return (int)Math.Pow(2, i);
                }
            }
        }
        bool CompareIfAGreaterThenB(byte[] first, byte[] second)
        {
            first = CutFirstNullValues(first);
            second = CutFirstNullValues(second);
            if (first.Length != second.Length && first.Length > second.Length)
                return true;
            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] > second[i])
                        return true;
                }
            }
            return false;
        }
        bool CompareIfASmallerThenB(byte[] first, byte[] second)
        {
            if (CompareIfAGreaterThenB(first,second))
            {
                return false;
            }
            if (CompareIfAGreaterThenB(second, first))
            {
                return true;
            }
            return false;
        }
        bool CompareIfAEqualB(byte[] first, byte[] second)
        {
            if (CompareIfAGreaterThenB(first, second)==false && CompareIfAGreaterThenB(second, first)==false)
            {
                return true;
            }
            return false;
        }
        private byte[] CutFirstNullValues(byte[] array)
        {
            int resultLength = CountFirstNullValues(array);
            byte[] result = new byte[array.Length - resultLength];
            if (resultLength > 0)
            {
                for (int i = resultLength; i < array.Length; i++)
                {
                    result[i - resultLength] = array[i];
                }
                return result;
            }
            else
                return array;
        }

        private int CountFirstNullValues(byte[] array)
        {
            int result = 0;
            foreach (var item in array)
            {
                if (item == 0)
                    result++;
                else
                    return result;
            }
            return result;
        }

        byte[] AddingNumbersInBaseX(byte[] firstNumber, byte[] secondNumber, int nrBase)
        {
            int remainder = 0;
            byte[] resultArray = new byte[Math.Max(firstNumber.Length, secondNumber.Length) + 1];
            for (int i = resultArray.Length - 1; i >= 0; i--)
            {
                int summ = GetNullIfOutOfArrayRange(firstNumber, resultArray.Length - 1 - i) + GetNullIfOutOfArrayRange(secondNumber, resultArray.Length - 1 - i) + remainder;
                remainder = summ / nrBase;
                resultArray[i] = (byte)(summ % nrBase);
            }
            return CutFirstNullValues(resultArray);
        }
        byte[] SubstractionNumbersInBaseX(byte[] firstNumber, byte[] secondNumber, int nrBase)
        {
            byte[] biggerNumber = firstNumber;
            byte[] smallerNumber = secondNumber;
            if (CompareIfAGreaterThenB(firstNumber, secondNumber) == false)
            {
                biggerNumber = secondNumber;
                smallerNumber = firstNumber;
            }
            int remainder = 0;
            byte[] resultArray = new byte[biggerNumber.Length];
            for (int i = biggerNumber.Length - 1; i >= 0; i--)
            {
                int summ = 0;
                if (GetNullIfOutOfArrayRange(biggerNumber, biggerNumber.Length - 1 - i) - remainder - GetNullIfOutOfArrayRange(smallerNumber, biggerNumber.Length - 1 - i) < 0)
                {
                    summ = Math.Abs(GetNullIfOutOfArrayRange(biggerNumber, biggerNumber.Length - 1 - i) - remainder + nrBase - GetNullIfOutOfArrayRange(smallerNumber, biggerNumber.Length - 1 - i));
                    remainder = 1;
                }
                else
                {
                    summ = GetNullIfOutOfArrayRange(biggerNumber, biggerNumber.Length - 1 - i) - remainder - GetNullIfOutOfArrayRange(smallerNumber, biggerNumber.Length - 1 - i);
                    remainder = 0;
                }
                resultArray[i] = (byte)summ;
            }
            return CutFirstNullValues(resultArray);
        }

        byte[] MultiplyInSelectedBase(byte[] v1, byte[] v2, int nrBase)
        {
            int resultLength = Math.Max(v1.Length, v2.Length);
            byte[] result = new byte[resultLength];
            byte[] multipliedWithOneElement = new byte[v2.Length];
            int reminder = 0;
            int counter = 0;
            for (int i = v1.Length - 1; i >= 0; i--)
            {
                for (int j = v2.Length - 1; j >= 0; j--)
                {
                    multipliedWithOneElement[j] = (byte)(GetNullIfOutOfArrayRange(v1, v1.Length - 1 - i) * GetNullIfOutOfArrayRange(v2, v2.Length - 1 - j) - reminder);
                    if (multipliedWithOneElement[j] >= nrBase)
                    {
                        reminder = multipliedWithOneElement[j] / nrBase;
                        multipliedWithOneElement[j] = (byte)(multipliedWithOneElement[i] % nrBase);
                    }
                    if (j == 0 && reminder > 0)
                    {
                        multipliedWithOneElement = AddZeroValuesToArrayUntilSpecifiedLength(multipliedWithOneElement, multipliedWithOneElement.Length + 1);
                        multipliedWithOneElement[j] = (byte)reminder;
                    }
                }
                if (counter > 0)
                {
                    multipliedWithOneElement = AddNullAtTheEnd(multipliedWithOneElement);
                }
                counter = 1;
                result = AddingNumbersInBaseX(result, multipliedWithOneElement, nrBase);
            }
            return CutFirstNullValues(result);
        }
        byte[] DevideInDesiredBase(byte[] v1, byte[] v2, int nrBase)
        {
            byte[] result = { 1 };           
            while (CompareIfAEqualB(v1, MultiplyInSelectedBase(v2, result, nrBase)) == false)
            {
                result = AddingNumbersInBaseX(result, new byte[] { 1 }, nrBase);
            }
            return result;
        }
        byte[] AddNullAtTheEnd(byte[] array)
        {
            byte[] result = array;
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = (byte)0;
            return result;
        }
    }
}
    

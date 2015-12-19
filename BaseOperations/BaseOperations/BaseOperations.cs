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
            CollectionAssert.AreEqual(new byte[] { 1 },TransformFromBaseTenToBaseTwo(1));
        }
        [TestMethod]
        public void Transform2FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new byte[] { 1 , 0 }, TransformFromBaseTenToBaseTwo(2));
        }
        [TestMethod]
        public void Transform15FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0,0,0,0 }, TransformFromBaseTenToBaseTwo(16));
        }
        [TestMethod]
        public void Transform260FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new byte[] { 1,0,0,0,0,0,1,0,0}, TransformFromBaseTenToBaseTwo(260));
        }

        byte[] TransformFromBaseTenToBaseTwo(int number)
        {    
            byte[] base2Array = {};
            while (number > 0)
            {
            Array.Resize(ref base2Array, base2Array.Length + 1);
            base2Array[base2Array.Length-1] = (byte) (number % 2);
                number = number / 2;
            }       
            return InvertArray(base2Array);
        }
        [TestMethod]
        public void InvertArray123()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 2, 1 }, InvertArray(new byte[] { 1,2,3}));
        }

        public byte[] InvertArray(byte[] array)
        {
            byte[] invertedArray = new byte[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                invertedArray[i] = array[array.Length-1-i];
            }
            return invertedArray;
        }
        [TestMethod]
        public void OROperation()
        {
            CollectionAssert.AreEqual(new byte[] {1,1}, BitOperation(TransformFromBaseTenToBaseTwo(1),TransformFromBaseTenToBaseTwo(2),"OR"));
        }
        [TestMethod]
        public void OROperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1,1,1 }, BitOperation(TransformFromBaseTenToBaseTwo(7), TransformFromBaseTenToBaseTwo(9), "OR"));
        }
        [TestMethod]
        public void ANDOperation()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0 }, BitOperation(TransformFromBaseTenToBaseTwo(1), TransformFromBaseTenToBaseTwo(2), "AND"));
        }
        [TestMethod]
        public void ANDOperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1 }, BitOperation(TransformFromBaseTenToBaseTwo(7), TransformFromBaseTenToBaseTwo(9), "AND"));
        }
        [TestMethod]
        public void XOROperation()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, BitOperation(TransformFromBaseTenToBaseTwo(1), TransformFromBaseTenToBaseTwo(2), "XOR"));
        }
        [TestMethod]
        public void XOROperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 0 }, BitOperation(TransformFromBaseTenToBaseTwo(7), TransformFromBaseTenToBaseTwo(9), "XOR"));
        }

        public byte[] BitOperation(byte[] v1, byte[] v2, string operation)
        {
            int arrayLength = Math.Max(v1.Length, v2.Length);
            byte[] result = new byte[arrayLength];
            for (int i = arrayLength-1; i >= 0; i--)
            {
               result[i] = WhichOperation(GetNullIfOutOfArrayRange(v1,arrayLength - 1 - i),GetNullIfOutOfArrayRange(v2,arrayLength - 1 - i), operation, i);
            }
            return result;
        }

        byte WhichOperation(byte v1, byte v2, string Operation, int i)
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

        [TestMethod]
        public void AddNulltoATwoElementsArrayIfIIsFive()
        {
            Assert.AreEqual(0, GetNullIfOutOfArrayRange(new byte[] {1,0 },5));
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
            Assert.AreEqual(1, GetNullIfOutOfArrayRange(new byte[] { 1,0,0,1,0, 0 }, 2));
        }
        byte GetNullIfOutOfArrayRange(byte[] array, int i)
        {
            return i < (array.Length) ? array[array.Length-1-i] : (byte)0;
        }
        [TestMethod]
        public void NOTOperation()
        {
            CollectionAssert.AreEqual(new byte[] {0, 1 }, NotOperation(TransformFromBaseTenToBaseTwo(2)));
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

        [TestMethod]
        public void AddZeroValueToOneElementArray()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1 }, AddZeroValuesToArrayUntilSpecifiedLength(new byte[] { 1}, 2 ));
        }
        [TestMethod]
        public void AddFiveZeroValueToOneElementArray()
        {
            CollectionAssert.AreEqual(new byte[] { 0,0,0,0,0, 1 }, AddZeroValuesToArrayUntilSpecifiedLength(new byte[] { 1 }, 6));
        }
        [TestMethod]
        public void AddZeroValueTotwoElementArray()
        {
            CollectionAssert.AreEqual(new byte[] {0, 0, 0, 0, 0, 0, 1, 0 }, AddZeroValuesToArrayUntilSpecifiedLength(TransformFromBaseTenToBaseTwo(2), 8));
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
        [TestMethod]
        public void ShiftToLeftTwoValueArray()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 0, 0, 0 }, ShiftToLeft(TransformFromBaseTenToBaseTwo(2),2));
        }
        [TestMethod]
        public void ShiftToLeftFourValuesArray()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 1, 0, 0, 0, 0 }, ShiftToLeft(new byte[]{1,0,1,0 }, 3));
        }
        byte[] ShiftToLeft(byte[] toBeShifted, int stepsToTheLeft)
        {
            if (toBeShifted.Length < 8)
            {
                toBeShifted = AddZeroValuesToArrayUntilSpecifiedLength(toBeShifted, 8);
            }
            byte[] shiftedResult = new byte[8];
            while (stepsToTheLeft > 0)
            {
                for (int i = 0; i < (toBeShifted.Length-2); i++)
                {
                    shiftedResult[i] = toBeShifted[i + 1];
                }
                    shiftedResult[7]=0;
                toBeShifted = shiftedResult;
                stepsToTheLeft--;
            }
            return shiftedResult;
        }
        [TestMethod]
        public void ShiftToRightTwoValueArray()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 0, 0, 1 }, ShiftToRight(TransformFromBaseTenToBaseTwo(2), 1));
        }
        [TestMethod]
        public void ShiftToRightFourValuesArray()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 0, 0, 1 }, ShiftToRight(new byte[] { 1, 0, 1, 0 }, 3));
        }
        byte[] ShiftToRight(byte[] toBeShifted, int stepsToTheRight)
        {
            if (toBeShifted.Length < 8)
            {
                toBeShifted = AddZeroValuesToArrayUntilSpecifiedLength(toBeShifted, 8);
            }
            byte[] shiftedResult = new byte[8];
            while (stepsToTheRight > 0)
            {
                for (int i = (toBeShifted.Length - 1); i > 0; i--)
                {
                    shiftedResult[i] = toBeShifted[i - 1];
                }
                shiftedResult[0] = 0;
                toBeShifted = shiftedResult;
                stepsToTheRight--;
            }
            return shiftedResult;
        }
        [TestMethod]
        public void CompareIfOneBasetwoIsGreaterThenTwoBaseTwo()
        {
            Assert.IsFalse(CompareIfAGreaterThenB(new byte[] { 1 }, new byte[] { 1, 0 }));
        }
        bool CompareIfAGreaterThenB(byte[] first, byte[] second)
        {
            first = CutFirstNullValues(first);
            second  = CutFirstNullValues(second);
            if (first.Length > second.Length)
                return true;
            if (first.Length < second.Length)
                return false;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] > second[i])
                    return true;
                else
                    return false;
            }
            return false;
        }
        [TestMethod]
        public void ReduceArrayByDeletingFirstTwoNullValues()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, CutFirstNullValues(new byte[] { 0, 0, 1, 0 }));
        }
        private byte[] CutFirstNullValues(byte[] array)
        {
            int resultLength = CountFirstNullValues(array);
            byte[] result = new byte[array.Length-resultLength];
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

        [TestMethod]
        public void AspectedTwoAfterCountingFirstNullValues()
        {
            Assert.AreEqual(2, CountFirstNullValues(new byte[] { 0, 0, 1, 0 }));
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

        [TestMethod]
        public void AddBaseTwoNumbers()
        {
            CollectionAssert.AreEqual(new byte[] {0,0,0,0,0,0, 1,1},AddingNumbersInBaseX(new byte[] { 1},new byte[] { 1,0}, 2));
        }
        [TestMethod]
        public void AddBaseTenNumbers()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 0, 4, 2 }, AddingNumbersInBaseX(new byte[] { 7 }, new byte[] { 3, 5 }, 10));
        }
        [TestMethod]
        public void AddBaseSixNumbers()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 3, 5, 3, 3, 4 }, AddingNumbersInBaseX(new byte[] { 3,4,5,2,1 }, new byte[] { 4,1,3 }, 6));
        }
        byte[] AddingNumbersInBaseX(byte[] firstNumber, byte[] secondNumber, int nrBase)
        {
            firstNumber = AddZeroValuesToArrayUntilSpecifiedLength(firstNumber, 8);
            secondNumber = AddZeroValuesToArrayUntilSpecifiedLength(secondNumber, 8);
            int remainder = 0;
            byte[] resultArray = new byte[8];
            for (int i = 7; i >= 0; i--)
            {
                int summ = firstNumber[i] + secondNumber[i] + remainder;
                remainder = summ / nrBase;
                resultArray[i] = (byte) (summ % nrBase);
            }
            return resultArray;
        }
        [TestMethod]
        public void SubstractBaseTwoNumbers()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 0, 0, 1 }, SubstractionNumbersInBaseX(new byte[] { 1,0 }, new byte[] { 1 }, 2));
        }
        [TestMethod]
        public void SubstractSeventeenFromThirtysevenBaseTwo()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1, 0, 1, 0, 0 }, SubstractionNumbersInBaseX(new byte[] { 0,0,1,0,0,1,0,1 }, new byte[] {0,0,0,1,0,0,0,1 }, 2));
        }
        [TestMethod]
        public void SubstractSeventeenFromThirtysevenBaseTwoWithFunction()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1, 0, 1, 0, 0 }, SubstractionNumbersInBaseX(TransformFromBaseTenToBaseTwo(37), TransformFromBaseTenToBaseTwo(17), 2));
        }
        byte[] SubstractionNumbersInBaseX(byte[] firstNumber, byte[] secondNumber, int nrBase)
        {
            firstNumber = AddZeroValuesToArrayUntilSpecifiedLength(firstNumber, 8);
            secondNumber = AddZeroValuesToArrayUntilSpecifiedLength(secondNumber, 8);
            byte[] biggerNumber = new byte[8];
            byte[] smallerNumber = new byte[8];
            if (CompareIfAGreaterThenB(firstNumber, secondNumber) == true)
            {
                biggerNumber = firstNumber;
                smallerNumber = secondNumber;
            }
            else
            {
                biggerNumber = firstNumber;
                smallerNumber = secondNumber;
            }
            int remainder = 0;
            byte[] resultArray = new byte[8];
            for (int i = 7; i >= 0; i--)
            {
                int summ = 0;
                if (biggerNumber[i] - remainder - smallerNumber[i] < 0)
                {
                    summ = Math.Abs(biggerNumber[i] - remainder + smallerNumber[i] - nrBase);
                    remainder = Math.Abs(summ - nrBase);
                    summ = CheckIfNumberDevideWithBaseAndReturnNull(summ, nrBase);
                }
                else
                {
                    summ = biggerNumber[i] - remainder + smallerNumber[i];
                    remainder = 0;
                    summ = CheckIfNumberDevideWithBaseAndReturnNull(summ, nrBase);
                }
                resultArray[i] = (byte) summ;
            }
            return resultArray;
        }
        [TestMethod]
        public void CheckIfNumberTwoDevideWithTwo()
        {
            Assert.AreEqual(0, CheckIfNumberDevideWithBaseAndReturnNull(2, 2));
        }
        int CheckIfNumberDevideWithBaseAndReturnNull(int numberToCheck, int baseNumber)
        {
            if (numberToCheck % baseNumber == 0)            
                return 0;
            else            
                return numberToCheck;
        }
    }
}

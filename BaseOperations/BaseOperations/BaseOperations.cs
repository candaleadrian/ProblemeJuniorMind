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
            CollectionAssert.AreEqual(new int[] { 1 },TransformFromBaseTenToBaseTwo(1));
        }
        [TestMethod]
        public void Transform2FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new int[] { 1 , 0 }, TransformFromBaseTenToBaseTwo(2));
        }
        [TestMethod]
        public void Transform15FromBase10ToBase2()
        {
            CollectionAssert.AreEqual(new int[] { 1, 0,0,0,0 }, TransformFromBaseTenToBaseTwo(16));
        }

        int[] TransformFromBaseTenToBaseTwo(int number)
        {    
            int[] base2Array = {};
            while (number > 0)
            {
            Array.Resize(ref base2Array, base2Array.Length + 1);
            base2Array[base2Array.Length-1] = number % 2;
                number = number / 2;
            }       
            return InvertArray(base2Array);
        }
        [TestMethod]
        public void InvertArray123()
        {
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, InvertArray(new int[] { 1,2,3}));
        }

        public int[] InvertArray(int[] array)
        {
            int[] invertedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                invertedArray[i] = array[array.Length-1-i];
            }
            return invertedArray;
        }
        [TestMethod]
        public void OROperation()
        {
            CollectionAssert.AreEqual(new int[] {1,1}, BitOperation(TransformFromBaseTenToBaseTwo(1),TransformFromBaseTenToBaseTwo(2),"OR"));
        }
        [TestMethod]
        public void OROperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 1,1,1 }, BitOperation(TransformFromBaseTenToBaseTwo(7), TransformFromBaseTenToBaseTwo(9), "OR"));
        }
        [TestMethod]
        public void ANDOperation()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0 }, BitOperation(TransformFromBaseTenToBaseTwo(1), TransformFromBaseTenToBaseTwo(2), "AND"));
        }
        [TestMethod]
        public void ANDOperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 1 }, BitOperation(TransformFromBaseTenToBaseTwo(7), TransformFromBaseTenToBaseTwo(9), "AND"));
        }
        [TestMethod]
        public void XOROperation()
        {
            CollectionAssert.AreEqual(new int[] { 1, 1 }, BitOperation(TransformFromBaseTenToBaseTwo(1), TransformFromBaseTenToBaseTwo(2), "XOR"));
        }
        [TestMethod]
        public void XOROperationSevenAndNine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 1, 1, 0 }, BitOperation(TransformFromBaseTenToBaseTwo(7), TransformFromBaseTenToBaseTwo(9), "XOR"));
        }

        public int[] BitOperation(int[] v1, int[] v2, string Operation)
        {
            int arrayLength = Math.Max(v1.Length, v2.Length);
            int[] result = new int[arrayLength];
            if (v1.Length > v2.Length)
                v2 = AddZeroValuesToArrayUntilSpecifiedLength(v2, v1.Length);
            if (v1.Length < v2.Length)
                v1 = AddZeroValuesToArrayUntilSpecifiedLength(v1, v2.Length);        
            for (int i = arrayLength-1; i >= 0; i--)
            {
               result[i] = WhichOperation(v1, v2, Operation, i);
            }
            return result;
        }

        int WhichOperation(int[] v1, int[] v2, string Operation, int i)
        {
            int result;
            switch (Operation)
            {
                case "OR":
                    return result = v1[i] == 1 || v2[i] == 1 ? 1 : 0;
//                    return result = (GetNullIfOutOfArrayRange(v1, i) == 1 || GetNullIfOutOfArrayRange(v2, i) == 1) ? 1 : 0;
                case "AND":
                    return result = v1[i] == 1 && v2[i] == 1 ? 1 : 0;
                case "XOR":
                    return result = v1[i] == v2[i] ? 0 : 1;
                default:
                    return 0;
            }
        }

        [TestMethod]
        public void AddNulltoATwoElementsArrayIfIIsFive()
        {
            Assert.AreEqual(0, GetNullIfOutOfArrayRange(new int[] {1,0 },5));
        }
        [TestMethod]
        public void AddNulltoAOneElementsArrayIfIIsOne()
        {
            Assert.AreEqual(0, GetNullIfOutOfArrayRange(new int[] { 1 }, 1));
        }
        [TestMethod]
        public void AddValueToATwoElementsArrayIfIIsNull()
        {
            Assert.AreEqual(1, GetNullIfOutOfArrayRange(new int[] { 1, 0 }, 0));
        }
        int GetNullIfOutOfArrayRange(int[] array, int i)
        {
            if (i<array.Length-1)            
                return array[i];
            else
                return 0;
        }
        [TestMethod]
        public void NOTOperation()
        {
            CollectionAssert.AreEqual(new int[] { 1,1,1,1,1,1,0, 1 }, NotOperation(TransformFromBaseTenToBaseTwo(2)));
        }
        int[] NotOperation(int[] notArray)
        {
            if (notArray.Length < 8)
            {
               notArray = AddZeroValuesToArrayUntilSpecifiedLength(notArray,8);
            }
            int[] notResult = new int[8];
            for (int i = 0; i < notArray.Length; i++)
            {
                if (notArray[i] == 1)
                    notResult[i] = 0;
                else
                    notResult[i] = 1;
            }
            return notResult;
        }

        [TestMethod]
        public void AddZeroValueToOneElementArray()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1 }, AddZeroValuesToArrayUntilSpecifiedLength(new int[] { 1}, 2 ));
        }
        [TestMethod]
        public void AddFiveZeroValueToOneElementArray()
        {
            CollectionAssert.AreEqual(new int[] { 0,0,0,0,0, 1 }, AddZeroValuesToArrayUntilSpecifiedLength(new int[] { 1 }, 6));
        }
        [TestMethod]
        public void AddZeroValueTotwoElementArray()
        {
            CollectionAssert.AreEqual(new int[] {0, 0, 0, 0, 0, 0, 1, 0 }, AddZeroValuesToArrayUntilSpecifiedLength(TransformFromBaseTenToBaseTwo(2), 8));
        }

        private int[] AddZeroValuesToArrayUntilSpecifiedLength(int[] arrayToModify, int arrayDesiredLength)
        {
            int[] invertedArray = InvertArray(arrayToModify);
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
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 1, 0, 0, 0 }, ShiftToLeft(TransformFromBaseTenToBaseTwo(2),2));
        }
        [TestMethod]
        public void ShiftToLeftFourValuesArray()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1, 0, 1, 0, 0, 0, 0 }, ShiftToLeft(new int[]{1,0,1,0 }, 3));
        }
        int[] ShiftToLeft(int[] toBeShifted, int stepsToTheLeft)
        {
            if (toBeShifted.Length < 8)
            {
                toBeShifted = AddZeroValuesToArrayUntilSpecifiedLength(toBeShifted, 8);
            }
            int[] shiftedResult = new int[8];
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
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 0, 0, 1 }, ShiftToRight(TransformFromBaseTenToBaseTwo(2), 1));
        }
        [TestMethod]
        public void ShiftToRightFourValuesArray()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 0, 0, 1 }, ShiftToRight(new int[] { 1, 0, 1, 0 }, 3));
        }
        int[] ShiftToRight(int[] toBeShifted, int stepsToTheRight)
        {
            if (toBeShifted.Length < 8)
            {
                toBeShifted = AddZeroValuesToArrayUntilSpecifiedLength(toBeShifted, 8);
            }
            int[] shiftedResult = new int[8];
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
            Assert.IsFalse(CompareIfAGreaterThenB(new int[] { 1 }, new int[] { 1, 0 }));
        }
        bool CompareIfAGreaterThenB(int[] first, int[] second)
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
            CollectionAssert.AreEqual(new int[] { 1, 0 }, CutFirstNullValues(new int[] { 0, 0, 1, 0 }));
        }
        private int[] CutFirstNullValues(int[] array)
        {
            int resultLength = array.Length - CountFirstNullValues(array);
            int[] result = new int[resultLength];
            for (int i = 0 + resultLength; i < array.Length; i++)
            {
                result[i - resultLength] = array[i];
            }
            return result;
        }

        [TestMethod]
        public void AspectedTwoAfterCountingFirstNullValues()
        {
            Assert.AreEqual(2, CountFirstNullValues(new int[] { 0, 0, 1, 0 }));
        }
        private int CountFirstNullValues(int[] array)
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
            CollectionAssert.AreEqual(new int[] {0,0,0,0,0,0, 1,1},AddingNumbersInBaseX(new int[] { 1},new int[] { 1,0}, 2));
        }
        [TestMethod]
        public void AddBaseTenNumbers()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 0, 4, 2 }, AddingNumbersInBaseX(new int[] { 7 }, new int[] { 3, 5 }, 10));
        }
        [TestMethod]
        public void AddBaseSixNumbers()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 3, 5, 3, 3, 4 }, AddingNumbersInBaseX(new int[] { 3,4,5,2,1 }, new int[] { 4,1,3 }, 6));
        }
        int[] AddingNumbersInBaseX(int[] firstNumber, int[] secondNumber, int nrBase)
        {
            firstNumber = AddZeroValuesToArrayUntilSpecifiedLength(firstNumber, 8);
            secondNumber = AddZeroValuesToArrayUntilSpecifiedLength(secondNumber, 8);
            int remainder = 0;
            int[] resultArray = new int[8];
            for (int i = 7; i >= 0; i--)
            {
                int summ = firstNumber[i] + secondNumber[i] + remainder;
                remainder = summ / nrBase;
                resultArray[i] = summ % nrBase;
            }
            return resultArray;
        }
        [TestMethod]
        public void SubstractBaseTwoNumbers()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 0, 0, 1 }, AddingNumbersInBaseX(new int[] { 1,0 }, new int[] { 1 }, 2));
        }
        int[] SubstractionNumbersInBaseX(int[] firstNumber, int[] secondNumber, int nrBase)
        {
            firstNumber = AddZeroValuesToArrayUntilSpecifiedLength(firstNumber, 8);
            secondNumber = AddZeroValuesToArrayUntilSpecifiedLength(secondNumber, 8);
            int remainder = 0;
            int[] resultArray = new int[8];
            int summ = 0;
            for (int i = 7; i >= 0; i--)
            {
                summ = 0;
                if (firstNumber[i] - remainder < secondNumber[i])
                {
                    summ = firstNumber[i] + nrBase - secondNumber[i];
                    remainder = 1;
                }
                else
                {
                    summ = firstNumber[i] - secondNumber[i]- remainder;
                    remainder = 0;
                }                
                resultArray[i] = summ;
            }
            return resultArray;
        }

    }
}

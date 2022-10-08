using ConditionalStatements;
using _Basic;
using BasicAlgorithm;
using DataTypes;
using For_Loop;
using _Functions;


/**
 * Solving questions from:
 * https://www.w3resource.com/csharp-exercises/basic/index.php
 */

namespace Main
{
    class Main_Class
    {
        static void Main (string[] args)
        {
            /**
             *  BASIC
             **/

            Basic B = new Basic();

//             Q1
               B.helloWorld();
//             Q2
               Console.WriteLine(B.sum2());            
//             Q3
               Console.WriteLine(B.divide2());
//             Q4
               B.printResults();
//             Q5
               B.swapNum();
//             Q6
               Console.WriteLine(B.multiply3());
//             Q7
               B.AllOps2();
//             Q8
               B.multiplicationTable();
//             Q9
               Console.WriteLine(B.FindAvg4());
//             Q10
               B.performFormula();
//             Q11
               B.olderThan();
//             Q12
               B.seperate4Lines();

            /**
            *  BASIC ALGORITHM
            **/

            Basic_Algorithm BA = new Basic_Algorithm();

            // Q1
            Console.WriteLine(BA.trippleSum(1, 2));
            Console.WriteLine(BA.trippleSum(3, 2));
            Console.WriteLine(BA.trippleSum(2, 2));

            // Q2
            Console.WriteLine(BA.absoluteDifference(53));
            Console.WriteLine(BA.absoluteDifference(30));
            Console.WriteLine(BA.absoluteDifference(51));

            // Q3
            Console.WriteLine(BA.thirtyChecker(30, 0));
            Console.WriteLine(BA.thirtyChecker(25, 5));
            Console.WriteLine(BA.thirtyChecker(20, 30));
            Console.WriteLine(BA.thirtyChecker(20, 25));

            // Q4
            Console.WriteLine(BA.withinRange(103));
            Console.WriteLine(BA.withinRange(90));
            Console.WriteLine(BA.withinRange(89));

            // Q5
            Console.WriteLine(BA.addToString("if else"));
            Console.WriteLine(BA.addToString("else"));

            // Q6
            Console.WriteLine(BA.removeChar("Python", 1));
            Console.WriteLine(BA.removeChar("Python", 0));
            Console.WriteLine(BA.removeChar("Python", 4));

            // Q7
            Console.WriteLine(BA.swapChars("abcd"));
            Console.WriteLine(BA.swapChars("a"));
            Console.WriteLine(BA.swapChars("xy"));

            // Q8
            BA.repeatString("C Sharp");
            BA.repeatString("JS");
            BA.repeatString("a");

            // Q9
            Console.WriteLine(BA.moveToFrontAndBack("Red"));
            Console.WriteLine(BA.moveToFrontAndBack("Green"));
            Console.WriteLine(BA.moveToFrontAndBack("1"));

            // Q10
            Console.WriteLine(BA.multiple37(3));
            Console.WriteLine(BA.multiple37(14));
            Console.WriteLine(BA.multiple37(12));
            Console.WriteLine(BA.multiple37(37));

            // Q11
            Console.WriteLine(BA.add3("Python"));
            Console.WriteLine(BA.add3("JS"));
            Console.WriteLine(BA.add3("Code"));

            // Q12
            Console.WriteLine(BA.startsWithCSharp("C# Sharp"));
            Console.WriteLine(BA.startsWithCSharp("C#"));
            Console.WriteLine(BA.startsWithCSharp("C++"));

            /**
            *  DATA TYPES
            **/

            Data_Types DT = new Data_Types();

            // Q1
            DT.inverse('b', 'a', 't');

            // Q2
            DT.printTriangle(6, 6);

            // Q3
            DT.login();

            // Q4
            DT.calculator();

            // Q5
            DT.areaOfCircle();

            // Q6
            DT.calculateEquation();

            // Q7
            DT.calculateSpeed();

            // Q8
            DT.areaOfSphere();

            // Q9
            DT.checkInputSymbol();

            // Q10
            DT.EvenOrOdd();

            // Q11
            DT.convertToBinary();

            /**
            *  CONDITIONAL STATEMENTS
            **/
            Conditional_Statements CS = new Conditional_Statements();

            // Q19
            CS.gradeDescription();

            // Q22
            CS.monthNumToString();

            // Q8
            CS.findLargest();

            // Q3
            CS.numSign();

            // Q6
            CS.displayN();

            // Q2
            CS.oddOrEven();

            // Q18
            CS.generateEletricBill();

            // Q24
            CS.calculateShapeArea();

            // Q25
            CS.calculator();

            // Q20
            CS.numToDay();

            // Q17
            CS.calculateProfitLoss();

            // Q12
            CS.generateDivision();

            /**
            *  For Loop
            **/

            ForLoop FL = new ForLoop();

            // Q3
            FL.displayNTerms();

            // Q5
            FL.cubeNum();

            // Q6
            FL.timesTable();

            // Q8
            FL.oddNums();

            // Q15
            FL.factorial();

            /**
            *  Array
            **/

            _Array.Array A = new _Array.Array();

            // Q1
            A.storeElements();

            // Q2
            A.reverseArray();

            // Q3
            A.sumElements();

            // Q4
            A.copyElements();

            // Q6
            A.uniqueElements();

            /**
             * String
             **/

            _String.String S = new _String.String();

            // Q7
            S.stringInfo();

            // Q13
            S.cutString();

            // Q14
            S.checkStringContents();

            /**
             * Functions
             **/

            Functions F = new Functions();

            // Q7
            F.power();

        }
    }
}

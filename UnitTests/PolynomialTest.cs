using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Polynomial
{
    [TestClass]
    public class PolynomialUnitTests
    {

	//mostly tests Degree and NumberOfTerms for various operations
	//requires extra checks using ToString()
        [TestMethod]
        public void ToStringReturn0()
        {
            Polynomial polynomial = new Polynomial();
            Assert.AreEqual("0", polynomial.ToString());
        }

        [TestMethod]
        public void DegreeReturn0()
        {
            Polynomial polynomial = new Polynomial();
            Assert.AreEqual(0, polynomial.Degree);
        }

        [TestMethod]
        public void DegreeUsesAddTerm()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual(1, polynomial.Degree);
        }

        [TestMethod]
        public void DegreeUsesAddTerm2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(2, 2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual(2, polynomial.Degree);
        }

        [TestMethod]
        public void DegreeUsesAddTerm3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual(2, polynomial.Degree);
        }

        /*[TestMethod]
        public void ToStringExpectFail()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);

            Term term2 = new Term(4, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Assert.AreEqual("foo", polynomial.ToString());
        }*/

        [TestMethod]
        public void AddTermAndToString()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreNotEqual(1, polynomial.ToString().Length);
        }

        [TestMethod]
        public void NumberOfTerms()
        {
            Polynomial polynomial = new Polynomial();
            Assert.AreEqual(0, polynomial.NumberOfTerms);
            Term term1 = new Term(0, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual(1, polynomial.NumberOfTerms);

            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual(2, polynomial.NumberOfTerms);
        }

        [TestMethod]
        public void AddTermSimplify()
        {
            Polynomial polynomial = new Polynomial();
            Assert.AreEqual(0, polynomial.NumberOfTerms);
            Term term1 = new Term(0, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual(1, polynomial.NumberOfTerms);

            Term term2 = new Term(0, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual(1, polynomial.NumberOfTerms);
        }

        [TestMethod]
        public void AddTermSimplify2Diff()
        {
            Polynomial polynomial = new Polynomial();
            Assert.AreEqual(0, polynomial.NumberOfTerms);
            Term term1 = new Term(0, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual(1, polynomial.NumberOfTerms);

            Term term2 = new Term(0, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual("5.1", polynomial.ToString().Substring(0,3));
        }

        [TestMethod]
        public void AddTerm1()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreNotEqual(1, polynomial.ToString().Length);
        }

        [TestMethod]
        public void AddTerm2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 0);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreNotEqual(1, polynomial.ToString().Length);
        }

        [TestMethod]
        public void AddPoly1()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(1, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(1, polynomialSum.Degree);
            Assert.AreEqual("+6x^1+4x^0", polynomialSum.ToString());
        }

        [TestMethod]
        public void AddPoly2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(3, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(2, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(3, polynomialSum.Degree);
        }

        [TestMethod]
        public void AddPoly3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(1, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(2, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(3, polynomialSum.NumberOfTerms);
            Assert.AreEqual(2, polynomialSum.Degree);
        }

        [TestMethod]
        public void AddPolyEmpty()
        {
            Polynomial polynomial = new Polynomial();

            Polynomial polynomial2 = new Polynomial();

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(0, polynomialSum.NumberOfTerms);
            Assert.AreEqual(0, polynomialSum.Degree);

        }

        [TestMethod]
        public void SubPoly0()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(1, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(0, polynomialSum.NumberOfTerms);
            Assert.AreEqual(0, polynomialSum.Degree);
            Assert.AreEqual("0", polynomialSum.ToString());
        }

        [TestMethod]
        public void SubPoly1()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(1, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(1, polynomialSum.Degree);
        }

        [TestMethod]
        public void SubPoly2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(2, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(1, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(3, polynomialSum.NumberOfTerms);
            Assert.AreEqual(2, polynomialSum.Degree);
        }

        [TestMethod]
        public void SubPoly3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(2, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(4, polynomialSum.Degree);
        }

        [TestMethod]
        public void NegateWithAdd()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = Polynomial.Negate(polynomial);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(0, polynomialSum.NumberOfTerms);
            Assert.AreEqual(0, polynomialSum.Degree);
            Assert.AreEqual("0", polynomialSum.ToString());
        }

        [TestMethod]
        public void Multiply1()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(6, polynomialSum.Degree);
        }

        [TestMethod]
        public void Multiply2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(12, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(80, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(92, polynomialSum.Degree);
        }

        [TestMethod]
        public void Multiply3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(12, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(2, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Term term = new Term(1, 3);
            polynomial.AddTerm(term.Coefficient, term.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(80, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(6, polynomialSum.NumberOfTerms);
            Assert.AreEqual(92, polynomialSum.Degree);
        }

        [TestMethod]
        public void Multiply4()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(12, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(2, 7.01);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Term term = new Term(1, 4.21);
            polynomial.AddTerm(term.Coefficient, term.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(6, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);
            Term term6 = new Term(4, 3.4);
            polynomial2.AddTerm(term6.Coefficient, term6.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(9, polynomialSum.NumberOfTerms);
            Assert.AreEqual(18, polynomialSum.Degree);
        }
    }
}

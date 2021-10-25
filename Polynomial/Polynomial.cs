using System;
using System.Collections.Generic;

namespace Polynomial
{
    public class Polynomial
    {
        public int Degree => NumberOfTerms==0 ? 0 : terms.First.Value.Power;
            
        public int NumberOfTerms => terms.Count;
      
        protected LinkedList<Term> terms;

        public Polynomial()
        {
            terms = new LinkedList<Term>();
        }

        // Add a new term with the given c and p to this polynomial
        public void AddTerm(double coefficient, int power)
        {
            Term term = new Term(power, coefficient);

            if (terms.Count == 0)
            {
                terms.AddFirst(term);
            }
            else
            {
                LinkedListNode<Term> currentNode = terms.First;
                while (currentNode != null)
                {
                    // if existing term with same power
                    // then add coefficients
                    if (currentNode.Value.Power == term.Power)
                    {
                        currentNode.Value.Coefficient += term.Coefficient;
                        return;
                    }

                    // if no exisiting term with same power
                    // then add new term at the right spot
                    if (currentNode.Value.Power < term.Power)
                    {
                        terms.AddBefore(currentNode, term);
                        return;
                    }

                    if(currentNode.Next == null )
                    {
                        terms.AddLast(term);
                        return;
                    }

                    currentNode = currentNode.Next;
                }
            }
        }


        public static Polynomial Add(Polynomial p1, Polynomial p2)
        {
            Polynomial sum = new Polynomial();

            // Add all terms from p1 to sum
            foreach (Term t in p1.terms)
            {
                sum.AddTerm(t.Coefficient, t.Power);
            }

            foreach( Term t in p2.terms)
            {
                sum.AddTerm(t.Coefficient, t.Power);
            }

            /*if (sum.terms.First.Value.Coefficient == 0)
            {
                var currentNode = sum.terms.Last;

                while (currentNode != null)
                {
                    sum.terms.RemoveLast();
                    currentNode = currentNode.Previous;
                }
            }*/

            var tempsum = new Polynomial();

            foreach (Term x in sum.terms)
            {
                tempsum.terms.AddLast(x);
            }

            foreach (Term t in tempsum.terms)
            {
                if (t.Coefficient == 0)
                {
                    sum.terms.Remove(t);
                }
            }

            return sum;
        }


        public static Polynomial Subtract(Polynomial p1, Polynomial p2)
        {
            return Add(p1, Negate(p2));
        }

        public static Polynomial Negate(Polynomial p)
        {
            Polynomial newp = new Polynomial();

            var currentNode = p.terms.First;

            while (currentNode != null)
            {
                int tempPower = currentNode.Value.Power;
                double tempCo = currentNode.Value.Coefficient;

                Term NegTerm = new Term(tempPower, -tempCo);
                newp.terms.AddLast(NegTerm);
                currentNode = currentNode.Next;
            }
            return newp;
        }

        public static Polynomial Multiply(Polynomial p1, Polynomial p2)
        {
           var tempPoly = new Polynomial();
           var product = new Polynomial();

           foreach(Term x in p1.terms)
           {
                tempPoly.terms.AddLast(x);
           }

           foreach(Term y in tempPoly.terms)
           {
                foreach(Term x in p2.terms)
                {
                    var tempTerm = new Term(y.Power += x.Power, y.Coefficient * x.Coefficient);
                    product.terms.AddLast(tempTerm);
                }
           }

            return product;

        }

        public override string ToString()
        {
            if(NumberOfTerms == 0)
            {
                return "0";
            }
            
            string result = "";

            foreach( Term t in terms)
            {
                if (terms.First.Value == t)
                {
                    result += t.ToString();
                }
                else
                {
                result += "+" + t.ToString();
                }
            }

            return result;
        }

    }
}

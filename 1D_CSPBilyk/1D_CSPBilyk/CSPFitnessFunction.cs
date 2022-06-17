using Accord.Genetic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_CSPBilyk
{
    public class CSPFitnessFunction : IFitnessFunction
    {
        private bool isComplexFunction;
        private int[] detailSizes;
        private int billetMaxLength;
        public CSPFitnessFunction(int[] array, int maxLength, bool isComplex)
        {
            this.detailSizes = array;
            this.isComplexFunction = isComplex;
            this.billetMaxLength = maxLength;
        }
        /// <summary>
        /// Translate genotype to phenotype 
        /// </summary>
        public object Translate(IChromosome chromosome)
        {
            return chromosome.ToString();
        }

        /// <summary>
        /// Evaluate chromosome - calculates its fitness value
        /// </summary>
        public double Evaluate(IChromosome chromosome)
        {
            if (isComplexFunction)
            {
                var result =  CalculateM(chromosome);
                if (result == null)
                {
                    return (double)0.9 / Math.Pow(billetMaxLength, 2);
                }
                else
                {
                    return CalculateSum(chromosome) / (double)result;
                }
            }
            else
            {
                
                var result = CalculateM(chromosome);
                if (result == null)
                {
                    return (double)0.9 / Math.Pow(billetMaxLength, 2);
                }
                else 
                {
                    return 1/ (double)result; 
                }
            }
        }

        public double CalculateSum(IChromosome chromosome)
        {
            double result = 0;
            ushort[] chromosomeArray = ((ShortArrayChromosome)chromosome).Value;
            var resultList = new List<ushort>();

            for (int i = 0; i < chromosomeArray.Length; i++)
            {
                if (!resultList.Contains(chromosomeArray[i]))
                {
                    resultList.Add(chromosomeArray[i]);
                }
            }
            for (int i = 0; i < resultList.Count; i++)
            {
                double tempBiletSum = 0;
                for (int j = 0; j < chromosomeArray.Length; j++)
                {
                    if (chromosomeArray[j] == resultList[i])
                    {
                        tempBiletSum += detailSizes[j];
                    }
                }

                tempBiletSum /= billetMaxLength;
                tempBiletSum *= tempBiletSum;
                result += tempBiletSum;
            }
            return result;
        }
        public int? CalculateM(IChromosome chromosome)
        {
            ushort[] chromosomeArray = ((ShortArrayChromosome)chromosome).Value;

            var resultList = new List<ushort>();

            for(int i = 0; i<chromosomeArray.Length; i++)
            {
                if (!resultList.Contains(chromosomeArray[i]))
                {
                    resultList.Add(chromosomeArray[i]);
                }
            }            

            for (int i=0; i<resultList.Count; i++)
            {
                var biletSum = 0;
                for (int j = 0; j<chromosomeArray.Length; j++)
                {
                    if (chromosomeArray[j] == resultList[i])
                    {
                        biletSum += detailSizes[j];
                    }
                }
                if (biletSum > billetMaxLength)
                {
                    return null;
                }
                
            }
            return resultList.Count;
        }
    }
}

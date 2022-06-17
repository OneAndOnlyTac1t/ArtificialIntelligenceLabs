using Accord.Genetic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPBilyk
{
    public class TSPFitnessFunction : IFitnessFunction
    {
        // map
        private double[,] map = null;
        private double maxSpeed = 0;

        public int LastPoint(IChromosome chromosome)
        {
            ushort[] path = ((PermutationChromosome)chromosome).Value;


            if (path[0] != 0)
            {
                var tempindex = 0;
                ushort[] tempArr = new ushort[path.Length];
                for (int i = 0; i < path.Length; i++)
                {
                    if (path[i] == 0)
                    {
                        tempindex = i;
                        break;
                    }
                }

                for (int i = 0; i < path.Length; i++)
                {
                    if (i < tempindex)
                    {
                        tempArr[tempArr.Length - tempindex + i] = path[i];
                    }
                    if (i == tempindex)
                    {
                        //tempArr[i] = path[tempArr.Length- (tempArr.Length - tempindex)];
                        tempArr[0] = path[i];
                    }
                    if (i > tempindex)
                    {
                        tempArr[i - tempindex] = path[i];
                    }

                }
                path = tempArr;
            }
            return path[path.Length-1];
        }

        public double ResultPath(IChromosome chromosome)
        {
            // salesman path
            ushort[] path = ((PermutationChromosome)chromosome).Value;

            // check path size
            if (path.Length != map.GetLength(0))
            {
                throw new ArgumentException("Invalid path specified - not all cities are visited");
            }

            // path length
            int prev = path[0];
            int curr = path[path.Length - 1];

            // calculate distance between the last and the first city
            double dx = map[curr, 0] - map[prev, 0];
            double dy = map[curr, 1] - map[prev, 1];
            double pathLength = Math.Sqrt(dx * dx + dy * dy);

            // calculate the path length from the first city to the last
            for (int i = 1, n = path.Length; i < n; i++)
            {
                // get current city
                curr = path[i];

                // calculate distance
                dx = map[curr, 0] - map[prev, 0];
                dy = map[curr, 1] - map[prev, 1];
                pathLength += Math.Sqrt(dx * dx + dy * dy);

                // put current city as previous
                prev = curr;
            }

            return pathLength;
        }

        // Constructor
        public TSPFitnessFunction(double[,] map, double speed)
        {
            this.map = map;
            this.maxSpeed = speed;
        }

        /// <summary>
        /// Evaluate chromosome - calculates its fitness value
        /// </summary>
        public double Evaluate(IChromosome chromosome)
        {
            return 1 / (CalculateTime(chromosome) + 1);
        }

        /// <summary>
        /// Translate genotype to phenotype 
        /// </summary>
        public object Translate(IChromosome chromosome)
        {
            return chromosome.ToString();
        }

        /// <summary>
        /// Calculate path length represented by the specified chromosome 
        /// </summary>
        public double CalculateTime(IChromosome chromosome)
        {
            // salesman path
            ushort[] path = ((PermutationChromosome)chromosome).Value;

            double v0 = 1, speed, result = 0;

            if (path[0] != 0)
            {
                var tempindex = 0;
                ushort[] tempArr = new ushort[path.Length];
                for (int i = 0; i < path.Length; i++)
                {
                    if (path[i] == 0)
                    {
                        tempindex = i;
                        break;
                    }
                }

                for (int i = 0; i < path.Length; i++)
                {
                    if (i < tempindex)
                    {
                        tempArr[tempArr.Length - tempindex + i] = path[i];
                    }
                    if (i == tempindex)
                    {
                        //tempArr[i] = path[tempArr.Length- (tempArr.Length - tempindex)];
                        tempArr[0] = path[i];
                    }
                    if (i > tempindex)
                    {
                        tempArr[i - tempindex] = path[i];
                    }

                }
                path = tempArr;
            }

            // check path size
            if (path.Length != map.GetLength(0))
            {
                throw new ArgumentException("Invalid path specified - not all cities are visited");
            }

            // path length
            int prev = path[0];
            int curr = path[path.Length - 1];

            // calculate distance between the last and the first city
            double dx = map[curr, 0] - map[prev, 0];
            double dy = map[curr, 1] - map[prev, 1];
            double pathLength = 0, tempPath = 0;

            //distance between first ant last city
            var initPath = Math.Sqrt(dx * dx + dy * dy);
            int speedcounter = 0;

            // calculate the path length from the first city to the last
            for (int i = 1, n = path.Length; i < n; i++)
            {
                // get current city
                curr = path[i];

                // calculate distance
                dx = map[curr, 0] - map[prev, 0];
                dy = map[curr, 1] - map[prev, 1];
                tempPath = Math.Sqrt(dx * dx + dy * dy);
                pathLength += tempPath;

                speed = v0 + (maxSpeed - v0) / (n - 1) * (speedcounter);
                result += tempPath / speed;
                speedcounter++;
                // put current city as previous
                prev = curr;
            }
            //time for distance between first and last city

            result += initPath / maxSpeed;

            return result;
        }
    }
}

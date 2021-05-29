using System;

namespace HWS_MDT112_63120501007
{
    class Program
    {
        static void Main(string[] args)
        {
            int imageWidth = int.Parse(Console.ReadLine());
            int imageHeihht = int.Parse(Console.ReadLine());
            Console.WriteLine(ImageProcessing(InputImageFile, ConvolutionKernelFileAddress, OutputImageFile, ""));
            Console.WriteLine(ImageProcessing(InputImageFile, ConvolutionKernelFileAddress, OutputImageFile - 1, ""));
            Console.WriteLine(ImageProcessing(InputImageFile, ConvolutionKernelFileAddress - 1, OutputImageFile, ""));
            Console.WriteLine(ImageProcessing(InputImageFile, ConvolutionKernelFileAddress + 1, OutputImageFile, ""));
            Console.WriteLine(ImageProcessing(InputImageFile, ConvolutionKernelFileAddress, OutputImageFile + 1, ""));

            static double[,] ReadImageDataFromFile(string imageDataFilePath)
            {
                string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
                int imageHeight = lines.Length;
                int imagewidth = lines[0].Split(",").Length;
                double[,] imageDataArray = new double[imageHeight, imagewidth];

                for (int i = 0; i < imageHeight; i++)
                {
                    string[] items = lines[i].Split(",");
                    for (int j = 0; j < imagewidth; j++)
                    {
                        imageDataArray[i, j] = double.Parse(items[j]);
                    }

                }
                return imageDataArray;

                int InputImageFile = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.ReadLine();

                int ConvolutionKernelFileAddress = int.Parse(Console.ReadLine());
                Console.ReadLine();

                static void writeImageDataToFile(string imageDataFilePath, double[,] imageDataArray)
                {
                    string imageDataString = "";
                    for (int i = 0; i < imageDataArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                        {
                            imageDataString += imageDataArray[i, j] + ", ";
                        }
                        imageDataString += imageDataArray[i, imageDataArray.GetLength(1) - 1];
                        imageDataString += "\n";
                    }
                    System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
                }

                int imageDataString = int.Parse(Console.ReadLine());
                Console.ReadLine();
            }
        }
    }
}


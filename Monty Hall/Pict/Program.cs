using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Pict
{
    class Program
    {
        public static object ImGearEvaluationManager { get; private set; }

        static void Main(string[] args)
        {
            // Initialize license for a Deployment(Runtime) license.
            //***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey
            //methods must be called to distribute the runtime.***
            //ImGearLicense.SetSolutionName("YourSolutionName");
            //ImGearLicense.SetSolutionKey(12345, 12345, 12345, 12345);
            //Manually Reported Runtime licenses also require the following method
            //call to SetOEMLicenseKey.
            //ImGearLicense.SetOEMLicenseKey("2.0.AStringForOEMLicensing...");

            // Initialize evaluation license.
            ImGearEvaluationManager.Initialize();

            // Initialize common formats.
            ImGearCommonFormats.Initialize();

            Console.WriteLine("Enter the complete path to the image to be converted:");
            string fileName = Console.ReadLine();

            Console.WriteLine("Enter the format for the new image among BMP|GIF|JPG|PNG|TIFF:");
            string newFormat = Console.ReadLine();

            try
            {
                using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    try
                    {

                        // Load the image into the page.
                        ImGearPage imGearPage = ImGearFileFormats.LoadPage(stream, 0);

                        // Resize the image to the width and height specified.
                        // ImGearInterpolations.BILINEAR is the value indicating the type of interpolation employed.
                        // It may be changed for other values, e.g. ImGearInterpolations.BICUBIC, ImGearInterpolations.NEAREST_NEIGHBOR.
                        ImGearProcessing.Resize(imGearPage, 150, 150, ImGearInterpolationOptions.GetDefault(ImGearInterpolations.BILINEAR));

                        string outputFileName = fileName.Substring(0, fileName.LastIndexOf('\\') + 1) + "out.";

                        // Indicate the format used when saving the image.
                        // It may be changed for other values, e.g. ImGearSavingFormats.JPG, ImGearSavingFormats.PNG.
                        ImGearSavingFormats savingFormat = ImGearSavingFormats.UNKNOWN;

                        // Identify the format selected.
                        switch (newFormat)
                        {

                            case "BMP":
                                outputFileName += "bmp";
                                savingFormat = ImGearSavingFormats.BMP_UNCOMP;
                                break;
                            case "GIF":
                                outputFileName += "gif";
                                savingFormat = ImGearSavingFormats.GIF;
                                break;
                            case "JPG":
                                outputFileName += "jpg";
                                savingFormat = ImGearSavingFormats.JPG;
                                break;
                            case "PNG":
                                outputFileName += "png";
                                savingFormat = ImGearSavingFormats.PNG;
                                break;
                            case "TIFF":
                                outputFileName += "tiff";
                                savingFormat = ImGearSavingFormats.TIF_UNCOMP;
                                break;
                            default:
                                Console.WriteLine("Unsupported format.");
                                break;
                        }

                        if (savingFormat != ImGearSavingFormats.UNKNOWN)
                        {
                            using (FileStream imGearConverted = new FileStream(outputFileName, FileMode.Create))
                            {
                                // Save the image to the format selected.   
                                ImGearFileFormats.SavePage(imGearPage, imGearConverted, 1, ImGearSavingModes.OVERWRITE, savingFormat, new ImGearSaveOptions());
                            }

                            Console.WriteLine("Conversion successful.");
                        }

                    }
                    catch (ImGearException ex)
                    {
                        Console.WriteLine("Conversion failed: " + ex.Message);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect path to an image file.");
            }
            Console.ReadLine();

        }

    }
}
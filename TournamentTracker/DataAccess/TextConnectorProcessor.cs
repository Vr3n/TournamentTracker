using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.DataAccess.TextConnHelper
{

    /// <summary>
    /// Class containing common methods for TextFile Related Databases.
    /// </summary>
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// Represent Full Path of the File name entered
        /// </summary>
        /// <param name="fileName">Name of the File you want Full Path of.</param>
        /// <returns>File Path string</returns>
        public static string FullFilePath(this string fileName) // PrizeModels.csv
        {
            string path = Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["filePath"]);

            return $"{path}\\{fileName}";
        }

        /// <summary>
        /// Load File and Convert into List of Strings. 
        /// </summary>
        /// <param name="file">Name of the File you want to load.</param>
        /// <returns>Content of Files in List of strings.</returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        /// <summary>
        /// Converting The Loaded Data to Prize Models String.
        /// </summary>
        /// <param name="lines">The Lines of Loaded Text File</param>
        /// <returns>List of Data (Prize Model)</returns>
        public static List<Models.PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<Models.PrizeModel> output = new List<Models.PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Models.PrizeModel p = new Models.PrizeModel();

                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = decimal.Parse(cols[4]);

                output.Add(p);
            }
            return output;
        }

        /// <summary>
        /// Converting The Loaded Data to Person Models String.
        /// </summary>
        /// <param name="lines">The Lines of Loaded Text File</param>
        /// <returns>List of Data (Person Model)</returns>
        public static List<Models.PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<Models.PersonModel> output = new List<Models.PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Models.PersonModel p = new Models.PersonModel();

                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellPhoneNumber = cols[4];

                output.Add(p);
            }
            return output;
        }
        
        /// <summary>
        /// Save Data To Prize File.
        /// </summary>
        /// <param name="models">Data of the Prize Model.</param>
        /// <param name="fileName">Name of the File to save Data of Prize Model</param>
        public static void SaveToPrizeFile(this List<Models.PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Models.PrizeModel prize in models)
            {
                lines.Add($"{prize.Id},{prize.PlaceNumber},{prize.PlaceName},{prize.PrizeAmount},{prize.PrizePercentage}");

            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

        /// <summary>
        /// Save Data To Person File.
        /// </summary>
        /// <param name="models">Data of the Person Model.</param>
        /// <param name="fileName">Name of the File to save Data of Person Model</param>
        public static void SaveToPersonFile(this List<Models.PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Models.PersonModel prize in models)
            {
                lines.Add($"{prize.Id},{prize.FirstName},{prize.LastName},{prize.EmailAddress},{prize.CellPhoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

    }
}

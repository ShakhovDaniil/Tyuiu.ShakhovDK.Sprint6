using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakhovDK.Sprint6.Task6.V24.Lib
{
    public class DataService : ISprint6Task6V24
    {
        public string CollectTextFromFile(string path)
        {
            string resstring = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Trim().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length > 0)
                    {
                        resstring += words[0] + " ";
                    }

                }
            }
            resstring = resstring.Trim();
            return resstring;
        }
    }
}

using System;
using System.IO;

namespace APItalent{
    /// <summary>
    ///   Static class needed only to read and setup the .env file.
    /// </summary>
    
    public static class EnvConfig{
        public static void EnvLoad(string filePath){
            if(File.Exists(filePath)){
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    if(string.IsNullOrWhiteSpace(line) || line.StartsWith("#")){
                        continue;
                    }

                    var parts = line.Split(new[] { '=' }, 2);
                    
                    if(parts.Length == 2){
                        var key = parts[0].Trim();
                        var value = parts[1].Trim();

                        Environment.SetEnvironmentVariable(key, value);
                    }
                }
            }
            else{
                throw new InvalidOperationException("Incorrect file path, cannot find .env file");
            }
        }

            /// <summary>
            ///   Example:
            ///     EnvConfig.EnvLoad("src/APItalent/Config.env");
            ///     string baseAdress = Environment.GetEnvironmentVariable("BASE_ADRESS");
            /// </summary>
    }
}
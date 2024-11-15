using System;
using Godot;

namespace APItalent{
    /// <summary>
    ///   Static class needed only to read and setup the .env file.
    /// </summary>
    
public static class EnvConfig
{
    public static void EnvLoad(string filePath)
    {
        if (FileAccess.FileExists(filePath))
        {
            using var file = FileAccess.Open(filePath, FileAccess.ModeFlags.Read);
            var lines = file.GetAsText().Split('\n');
            file.Close();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                {
                    continue;
                }

                var parts = line.Split(new[] { '=' }, 2);

                if (parts.Length == 2)
                {
                    var key = parts[0].Trim();
                    var value = parts[1].Trim();

                    System.Environment.SetEnvironmentVariable(key, value);
                }
            }
            GD.Print("Env file load succses");
        }
        else
        {
            throw new InvalidOperationException("Incorrect file path, cannot find .env file");
        }
    }
}
}
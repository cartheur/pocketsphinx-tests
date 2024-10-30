
using System.Diagnostics;

public class Program
{
    // Pocketsphinx voice recognition system
    public static bool SphinxUsed { get; set; }
    public static bool PocketSphinxPythonUsed { get; set; }
    public static Process PocketSphinxProcess { get; set; }
    public static Process PocketSphinxPythonProcess { get; set; }
    public static string PocketSphinxPythonProcessOutput { get; set; }
    public static int PocketSphinxPythonProcessExitCode { get; set; }
    public static string PocketsphinxFileDrop { get; set; }
    public static StreamReader PythonProcessStream { get; set; }
    public static bool AeonLoaded { get; set; }
    /// <summary>
    /// Initializes the speech recognizer.
    /// </summary>
    /// <returns></returns>
    public static bool InitializePocketSphinx()
    {
        // Do something here.
        return false;
    }

    static void Main(string[] args)
    {
        PocketSphinxPythonUsed = Convert.ToBoolean(_thisAeon.GlobalSettings.GrabSetting("pocketsphinxused"));
        AeonLoaded = true;
        // Determine whether to load Windows speech synthesizer.
        if (PocketSphinxPythonUsed && AeonLoaded)
            InitializePocketSphinx();
        //if (SapiWindowsUsed)
            //InitializeSpeechRecognizer();

        Console.WriteLine("Hello, Worldly!");
    }
}